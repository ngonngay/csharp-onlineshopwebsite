using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Application.Catalog.Users;
using Project.Data.EF;
using Project.Data.Entities;
using Project.Data.Enums;
using Project.Utilities.Exceptions;
using Project.ViewModels.cart;
using Project.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Sales
{
    public class CartService : ICartService
    {
        private readonly ProjectDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserService _userService;
        /* private readonly IStorageService _storageService;
         private const string USER_CONTENT_FOLDER_NAME = "user-content";*/
        public CartService(ProjectDbContext projectDbContext, UserManager<AppUser> userManager, IUserService userService)
        {
            _context = projectDbContext;
            _userManager = userManager;
            _userService = userService;
            //_storageService = storageService;
        }

        public RequestResult<bool> AddNewItemToCart(CartAddNewItemRequest request)
        {
            try
            {
                var user = _userManager.Users.Where(user => user.Id == request.UserId).First();
                Cart cartRecord = new Cart()
                {
                    //Id = request.id,
                    ProductId = request.productId,
                    AppUser = user,
                    Quantity = request.Quantity,
                    Price = request.Price,
                    size=request.Size,
                    DateCreated = DateTime.Now
                };
                _context.Carts.Add(cartRecord);
                _context.SaveChanges();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }

        public  RequestResult<bool> CreateOrder(string userId)
        {

            try
            {
                
                var addressCard = _userService.GetAddressCard(0, userId, "active");
                var Order = new Order() {
                    OrderDate = DateTime.Now,
                    UserId = userId,
                    ShipName = addressCard.ResultObj.FullName,
                    ShipAddress = addressCard.ResultObj.address,
                    ShipEmail = _userManager.GetEmailAsync(_userManager.FindByIdAsync(userId).Result).Result,
                    ShipPhoneNumber = addressCard.ResultObj.phoneNumber,
                    Status = OrderStatus.New,
                    CityId = addressCard.ResultObj.CityId,
                    City=addressCard.ResultObj.City,
                    DistricstId = addressCard.ResultObj.DistricstId,
                    Districst = addressCard.ResultObj.Districst,
                    WardsId = addressCard.ResultObj.WardsId,
                    Wards = addressCard.ResultObj.Ward
                };
                _context.Orders.Add(Order);
                _context.SaveChanges();
                var cart = _context.Carts.Where(cart => cart.UserId == userId).Join(_context.Products.Include(p => p.ProductImages), // the source table of the inner join
                       cart => cart.ProductId,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                       product => product.Id,   // Select the foreign key (the second part of the "on" clause)
                       (cart, product) => new { Cart = cart, Product = product });
                var orderDetail= cart.Select(cart => new OrderDetail()
                {
                    OrderId = Order.Id,
                    ProductId = cart.Cart.ProductId,
                    Quantity = cart.Cart.Quantity,
                    Price = cart.Cart.Price,
                    size = cart.Cart.size,
                    productName=cart.Product.Name,
                    total = cart.Cart.Price * cart.Cart.Quantity
                }).ToList();
                decimal total = 0;
                foreach (var item in orderDetail)
                {
                    total += item.total;
                    _context.OrderDetails.Add(item);
                }
                Order.total = total;
                var carts = _context.Carts.Where(cart => cart.UserId == userId);
                foreach (var item in carts)
                {
                    _context.Carts.Remove(item);
                }
                var user = _userManager.FindByIdAsync(userId).Result;
                if (user.PhoneNumber==null)
                {
                    user.PhoneNumber = addressCard.ResultObj.phoneNumber;
                    
                }
                
                Notification notification = new Notification()
                {
                    UserId = userId,
                    date = DateTime.Now,
                    Type = NotificationType.Order,
                    Targetint = Order.Id,
                    content = "Đơn hàng #"+Order.Id+" đã được tạo thành công. Bấm vào Chi Tiết để theo dõi đơn hàng"
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

        public RequestResult<CartViewModel> GetCart(string userId)
        {
            try
            {
                //var CartCheck = _context.Carts.Where(cart => cart.UserId == userId);
                var cart = _context.Carts.Where(cart => cart.UserId == userId).Join(_context.Products.Include(p => p.ProductImages), // the source table of the inner join
                      cart => cart.ProductId,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                      product => product.Id,   // Select the foreign key (the second part of the "on" clause)
                      (cart, product) => new { Cart = cart, Product = product });
                if (!cart.Any())
                {
                    return new RequestErrorResult<CartViewModel>("null");
                }
                var CartInDb = new CartViewModel()
                {
                    id=cart.Select(cart=>cart.Cart.Id).First(),
                    UserId= cart.Select(cart => cart.Cart.UserId).First(),
                    DateCreated= cart.Select(cart => cart.Cart.DateCreated).First(),
                    cartItem= cart.Select(cart=>new CartItemViewModel()
                    {
                        ProductId = cart.Cart.ProductId,
                        Description = cart.Product.Description,
                        Image = cart.Product.ProductImages.First().ImagePath,
                        Name = cart.Product.Name,
                        Price = cart.Cart.Price,
                        Size=cart.Cart.size,
                        Quantity = cart.Cart.Quantity
                    }).ToList()
                };
                if (CartInDb.cartItem== null)
                {
                    return new RequestSuccessResult<CartViewModel>(null);
                }
                return new RequestSuccessResult<CartViewModel>(CartInDb);
            }
            catch (Exception e)
            {

                return new RequestErrorResult<CartViewModel>(e.InnerException.Message);
            }
        }

        public  RequestResult<bool> UpdateQuantityInCart(CartUpdateRequest request)
        {
            try
            {
                //var cart =  _context.Carts.Where(cart=> cart.Id==request.id&& cart.ProductId==request.productId&&cart.UserId.Equals(request.UserId)).First() ;
                //var cart = await _context.Carts.FirstAsync(request.id,request.productId,request.UserId);
                var cart = (from cartrow in _context.Carts where  cartrow.ProductId == request.productId && cartrow.UserId.Equals(request.UserId) && cartrow.size.Equals(request.size) select cartrow).FirstOrDefault();
                
                if (cart == null) throw new ProjectException($"Cannot find a product with id: {request.id}");
                if (request.Quantity==0)
                {
                    _context.Remove(cart);
                    _context.SaveChanges();
                }
                else
                {
                    cart.Quantity = request.Quantity;
                }

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
