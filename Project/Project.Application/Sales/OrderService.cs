using Project.Data.EF;
using Project.ViewModels.common;
using Project.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Project.ViewModels.User;
using Project.Application.Catalog.Products;
using Project.Data.Enums;
using Project.Data.Entities;

namespace Project.Application.Sales
{
    public class OrderService : IOrderService
    {
        private readonly ProjectDbContext _context;
        private readonly IProductService _productService;
       
        public OrderService(ProjectDbContext projectDbContext, IProductService productService)
        {
            _context = projectDbContext;
            _productService = productService;
        }
        public RequestResult<PageResult<OrderViewModel>> GetAllOrder(GetOrderPagingRequest request)
        {
            try
            {
                //get all order
                var orderNTT = _context.Orders.Include(order=>order.OrderDetails).Include(order=>order.AppUser).OrderBy(o=>o.Status).OrderByDescending(o => o.OrderDate).Select(o=>o);
                //filter
                //by status
                if (request.status >-1)
                {
                    orderNTT = orderNTT.Where(p => (int)p.Status==request.status);
                }
                //by productname
                if (request.productName != null && !String.IsNullOrEmpty(request.productName))
                {
                    orderNTT = orderNTT.Where(p => p.OrderDetails.Any(name=>name.productName.Contains(request.productName)));
                }
                //by username
                if (!string.IsNullOrEmpty(request.username))
                    orderNTT = orderNTT.Where(x =>x.ShipName.Contains(request.username));
                //by orderid
                if (request.OrderId != 0)
                {
                    orderNTT = orderNTT.Where(p => p.Id== request.OrderId);
                }
                ////3. Paging
                int totalRow =  orderNTT.Count();
                var data = orderNTT.Select(order => new OrderViewModel()
                {
                    OrderId =order.Id,
                    OrderDate = order.OrderDate,
                    User = new UserViewModel()
                    {
                        Id = order.AppUser.Id,
                        UserName = order.AppUser.UserName,
                        Email = order.AppUser.Email,
                        PhoneNumber = order.AppUser.PhoneNumber ?? "",
                        Fullname = order.AppUser.FullName,
                        Birthday = order.AppUser.Birthday,
                        Address = order.AppUser.Address,
                        Disable = order.AppUser.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
                    },
                    ShipName = order.ShipName,
                    ShipAddress = order.ShipAddress,
                    ShipEmail = order.ShipEmail,
                    ShipPhoneNumber = order.ShipPhoneNumber,
                    ShippingFee = order.ShippingFee,
                    Status = order.Status,
                    CityId = order.CityId,
                    City = order.City??_context.Cities.Where(c=>c.CityId==order.CityId).Select(c=>c.Name).First(),
                    DistricstId = order.DistricstId,
                    Districst = order.Districst?? _context.Districts.Where(c => c.CityId == order.CityId && c.Id == order.DistricstId).Select(c => c.Name).First(),
                    WardsId = order.WardsId,
                    Wards = order.Wards?? _context.Wards.Where(c => c.CityId == order.CityId && c.DistrictId == order.DistricstId && c.Id==order.WardsId).Select(c => c.Name).First(),
                    CustomerNote = order.CustomerNote,
                    StaffNote = order.StaffNote,
                    total = order.total,
                    cancleReason = order.cancleReason,
                    ordertItem  = order.OrderDetails.Select(detail=>new OrderItemViewModel()
                                 {
                                    ProductId =detail.ProductId,
                                    Quantity = detail.Quantity,
                                    Name = detail.productName??_context.Products.Where(p=>p.Id==detail.ProductId).Select(p=>p.Name).First(),
                                    Image=_context.ProductImages.Where(img => img.ProductId == detail.ProductId && img.IsDefault == true).Select(x=>x.ImagePath).FirstOrDefault(),
                                    Size = detail.size,
                                    Price = detail.Price,
                                 }).ToList()
                }).ToList();
                
                //4. Select and projection
                var pagedResult = new PageResult<OrderViewModel>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return new RequestSuccessResult<PageResult<OrderViewModel>>(pagedResult);
            }
            catch (Exception e)
            {
                
                return new RequestErrorResult<PageResult<OrderViewModel>>(e.Message);
            }
        }

        public RequestResult<List<OrderViewModel>> GetAllOrder(string userId)
        {
            try
            {
                //get all order
                var orderNTT = _context.Orders.Where(o=>o.UserId==userId).Include(order => order.OrderDetails).Include(order => order.AppUser).Select(o => o).OrderBy(o => o.Status).OrderByDescending(o => o.OrderDate);
                ////3. Paging
                int totalRow = orderNTT.Count();
                var data = orderNTT.Select(order => new OrderViewModel()
                {
                    OrderId = order.Id,
                    OrderDate = order.OrderDate,
                    User = new UserViewModel()
                    {
                        Id = order.AppUser.Id,
                        UserName = order.AppUser.UserName,
                        Email = order.AppUser.Email,
                        PhoneNumber = order.AppUser.PhoneNumber ?? "",
                        Fullname = order.AppUser.FullName,
                        Birthday = order.AppUser.Birthday,
                        Address = order.AppUser.Address,
                        Disable = order.AppUser.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
                    },
                    ShipName = order.ShipName,
                    ShipAddress = order.ShipAddress,
                    ShipEmail = order.ShipEmail,
                    ShipPhoneNumber = order.ShipPhoneNumber,
                    ShippingFee = order.ShippingFee,
                    Status = order.Status,
                    CityId = order.CityId,
                    City = order.City ?? _context.Cities.Where(c => c.CityId == order.CityId).Select(c => c.Name).First(),
                    DistricstId = order.DistricstId,
                    Districst = order.Districst ?? _context.Districts.Where(c => c.CityId == order.CityId && c.Id == order.DistricstId).Select(c => c.Name).First(),
                    WardsId = order.WardsId,
                    Wards = order.Wards ?? _context.Wards.Where(c => c.CityId == order.CityId && c.DistrictId == order.DistricstId && c.Id == order.WardsId).Select(c => c.Name).First(),
                    CustomerNote = order.CustomerNote,
                    StaffNote = order.StaffNote,
                    total = order.total,
                    cancleReason = order.cancleReason,
                    ordertItem = order.OrderDetails.Select(detail => new OrderItemViewModel()
                    {
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        Name = detail.productName ?? _context.Products.Where(p => p.Id == detail.ProductId).Select(p => p.Name).First(),
                        Image = _context.ProductImages.Where(img => img.ProductId == detail.ProductId && img.IsDefault == true).Select(x => x.ImagePath).FirstOrDefault()?? _context.ProductImages.Where(img => img.Id == detail.ProductId).Select(x => x.ImagePath).FirstOrDefault(),
                        Size = detail.size,
                        Price = detail.Price
                    }).ToList()
                }).ToList();
                return new RequestSuccessResult<List<OrderViewModel>>(data);
            }
            catch (Exception e)
            {

                return new RequestErrorResult<List<OrderViewModel>>(e.Message);
            }
        }

        public RequestResult<OrderViewModel> GetOrderById(int orderId)
        {
            try
            {
                var orderNTT = _context.Orders.Where(o => o.Id == orderId).Include(order => order.OrderDetails).Include(order => order.AppUser).Select(o => o);
                
                var data = orderNTT.Select(order => new OrderViewModel()
                {
                    OrderId = order.Id,
                    OrderDate = order.OrderDate,
                    User = new UserViewModel()
                    {
                        Id = order.AppUser.Id,
                        UserName = order.AppUser.UserName,
                        Email = order.AppUser.Email,
                        PhoneNumber = order.AppUser.PhoneNumber ?? "",
                        Fullname = order.AppUser.FullName,
                        Birthday = order.AppUser.Birthday,
                        Address = order.AppUser.Address,
                        Disable = order.AppUser.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
                    },
                    ShipName = order.ShipName,
                    ShipAddress = order.ShipAddress,
                    ShipEmail = order.ShipEmail,
                    ShipPhoneNumber = order.ShipPhoneNumber,
                    ShippingFee = order.ShippingFee,
                    Status = order.Status,
                    CityId = order.CityId,
                    City = order.City ?? _context.Cities.Where(c => c.CityId == order.CityId).Select(c => c.Name).First(),
                    DistricstId = order.DistricstId,
                    Districst = order.Districst ?? _context.Districts.Where(c => c.CityId == order.CityId && c.Id == order.DistricstId).Select(c => c.Name).First(),
                    WardsId = order.WardsId,
                    Wards = order.Wards ?? _context.Wards.Where(c => c.CityId == order.CityId && c.DistrictId == order.DistricstId && c.Id == order.WardsId).Select(c => c.Name).First(),
                    CustomerNote = order.CustomerNote,
                    StaffNote = order.StaffNote,
                    total = order.total,
                    cancleReason = order.cancleReason,
                    ordertItem = order.OrderDetails.Select(detail => new OrderItemViewModel()
                    {
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        Name = detail.productName ?? _context.Products.Where(p => p.Id == detail.ProductId).Select(p => p.Name).First(),
                        Image = _context.ProductImages.Where(img => img.ProductId == detail.ProductId && img.IsDefault == true).Select(x => x.ImagePath).FirstOrDefault(),
                        Size = detail.size,
                        Price = detail.Price
                    }).ToList()
                }).First();
                /*var x=orderNTT.Select(o => o).First();
                x.total += x.OrderDetails.Select(p => p.Price * p.Quantity).First();
                _context.SaveChanges();*/
                return new RequestSuccessResult<OrderViewModel>(data);
            }
            catch (Exception e)
            {

                return new RequestErrorResult<OrderViewModel>(e.Message);
            }
        }

        public RequestResult<ReportViewModel> GetReport()
        {
            try
            {
                var order = _context.Orders.Select(o => o);
                var newReportInfo = new ReportViewModel()
                {
                    NewOrder = order.Where(o => o.Status == OrderStatus.New).Count(),
                    ProcessingOrder=order.Where(order=>order.Status!=OrderStatus.New||order.Status!=OrderStatus.Success||order.Status!=OrderStatus.Canceled).Count(),
                    SuccessOrder=order.Where(o=>o.Status==OrderStatus.Success).Count(),
                    CancleOrder=order.Where(o=>o.Status==OrderStatus.Canceled).Count()
                };
                return new RequestSuccessResult<ReportViewModel>(newReportInfo);
            }
            catch (Exception e)
            {

                return new RequestErrorResult<ReportViewModel>(e.Message);
            }
        }

        public RequestResult<bool> UpdateStatus(int orderId, int selectedStatus, string reason = null)
        {
            try
            {
                var order = _context.Orders.Where(o => o.Id == orderId).First();
                order.Status = (OrderStatus) selectedStatus;
                if (selectedStatus==5) 
                {
                    order.cancleReason = reason;
                }
                _context.SaveChanges();
                var content = order.Status == OrderStatus.Shipping ? "Đơn hàng  #" + order.Id + " đã sẵn sàng để giao đến quý khách. Chúng tôi vừa bàn giao đơn hàng của quý khách đến đối tác vận chuyển eShops Team. Đơn hàng sẽ được giao trước 23:59 ngày 18/12/2021. Bấm vào Chi Tiết để theo dõi đơn hàng" : order.Status == OrderStatus.Canceled ? "Đơn hàng #" + order.Id + " đã bị hủy. Lý do : " + reason + "." : "Đơn hàng #" + order.Id + " đã được giao thành công . Xin chân thành cảm ơn Quý Khách đã tin tưởng và sử dụng dịch vụ của eShops";
                Notification notification = new Notification()
                {
                    UserId = order.UserId,
                    date = DateTime.Now,
                    Type = NotificationType.Order,
                    Targetint = order.Id,
                    content =order.Status == OrderStatus.Confirmed ? "Đơn hàng #" + order.Id + " đã được xác nhận. Bấm vào Chi Tiết để theo dõi đơn hàng" : order.Status == OrderStatus.InProgress ? "Đơn hàng #" + order.Id + " đang được đóng gói. Bấm vào Chi Tiết để theo dõi đơn hàng" :content
                };
                _context.Notifications.Add(notification);
                _context.SaveChanges();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {
                return new RequestErrorResult<bool>(e.Message);
            }
        }
    }
}
