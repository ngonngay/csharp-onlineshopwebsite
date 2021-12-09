using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Data.Entities;
using Project.Data.Enums;
using Project.ViewModels.common;
using Project.ViewModels.Notification;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Application.Catalog.Users
{
    public class UserService : IUserService
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        
        private readonly ProjectDbContext _projectDbContext;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,  ProjectDbContext projectDbContext)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            
            _projectDbContext = projectDbContext;
        }



        public async Task<PageResult<UserViewModel>> GetAllUser(string role)
        {

            var data = await (from user in _userManager.Users
                              join userRoles in _projectDbContext.UserRoles on user.Id equals userRoles.UserId
                              join roles in _projectDbContext.Roles on userRoles.RoleId equals roles.Id
                              where roles.Name == "staff"
                              select user).Select(user => new UserViewModel()
                              {
                                  Id = user.Id,
                                  UserName = user.UserName,
                                  Email = user.Email,
                                  PhoneNumber = user.PhoneNumber ?? "",
                                  Fullname = user.FullName,
                                  Birthday = user.Birthday,
                                  Address = user.Address,
                                  Disable = user.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
                              }).ToListAsync();
            var staff = await (from user in _userManager.Users
                               join userRoles in _projectDbContext.UserRoles on user.Id equals userRoles.UserId
                               join roles in _projectDbContext.Roles on userRoles.RoleId equals roles.Id
                               where roles.Name == "staff"
                               select user).Select(user => new UserViewModel()
                               {
                                   Id = user.Id,
                                   UserName = user.UserName,
                                   Email = user.Email,
                                   PhoneNumber = user.PhoneNumber ?? "",
                                   Fullname = user.FullName,
                                   Birthday = user.Birthday,
                                   Address = user.Address,
                                   Disable = user.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
                               }).ToListAsync();
            var data2 = await _projectDbContext.Users.Select(user => new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber ?? "",
                Fullname = user.FullName,
                Birthday = user.Birthday,
                Address = user.Address,
                Disable = user.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
            }).ToListAsync();
            if (role == "customer")
            {
               
                foreach (var item in data2)
                {
                    foreach (var staffrole in staff)
                    {
                        if (item.Id == staffrole.Id)
                        {
                            data2.Remove(item);
                        }
                    }
                }
            }
            
            //var data =  query.Select(user => new UserViewModel()
            //{
            //    Id = user.Id,
            //    UserName = user.UserName,
            //    Email = user.Email,
            //    PhoneNumber = user.PhoneNumber ?? "",
            //    Fullname = user.FullName,
            //    Birthday = user.Birthday,
            //    Address = user.Address,
            //    Disable = user.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
            //});
            return new PageResult<UserViewModel>() { Items = data2 };
        }

        public async Task<UserViewModel> GetById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var addressCard = GetAddressCard(0, id, "active");
            var totalOrder = _projectDbContext.Orders.Where(x => x.UserId == id).Count();
            var result = new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber ?? "",
                Fullname = user.FullName,
                Birthday = user.Birthday,
                Address =(addressCard.ResultObj !=null)?addressCard.ResultObj.addressCDW:"",
                totalOrder=totalOrder,
                EmailConfirmed = user.EmailConfirmed ? "Đã Xác Nhận" : "Chưa Xác Nhận"
            };
            return result;
        }
        public async Task<bool> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.disable = true;
                var result = await _userManager.UpdateAsync(user);
                return result.Succeeded;
            }
            return false;
        }
        public RequestResult<List<AddressCardViewModel>> GetAddressCard(string userId, string orderby = null)
        {
            try
            {
                var AddrCards = _projectDbContext.Addresses.Where(addr => addr.UserId == userId).OrderByDescending(addr=>addr.isDefault);
                if (orderby != null)
                {
                    if (orderby=="status")
                    {
                        AddrCards= _projectDbContext.Addresses.Where(addr => addr.UserId == userId).OrderBy(addr => addr.status);
                    }
                }
                var AddressCard =AddrCards.Select(AddrCard=>new AddressCardViewModel()
                {
                    AddressCardId=AddrCard.AddressCardId,
                    UserId = userId,
                    FullName = AddrCard.FullName,
                    phoneNumber = AddrCard.phoneNumber,
                    address = AddrCard.address,
                    CityId = AddrCard.CityId,
                    City = AddrCard.City,
                    DistricstId = AddrCard.DistricstId,
                    Districst = AddrCard.Districst,
                    WardsId = AddrCard.WardsId,
                    Ward = AddrCard.Ward,
                    status = AddrCard.status,
                    isDefault = AddrCard.isDefault
                }).ToList();

                return new RequestSuccessResult<List<AddressCardViewModel>> (AddressCard);
            }
            catch (Exception e)
            {
                return new RequestErrorResult<List<AddressCardViewModel>> (e.Message);
            }
        }
        public RequestResult<List<AddressCardViewModel>> GetActiveAddressCard(string userId)
        {
            try
            {
                var AddrCards = _projectDbContext.Addresses.Where(addr => addr.UserId == userId&& addr.status==0).OrderByDescending(addr => addr.isDefault);
                var AddressCard = AddrCards.Select(AddrCard => new AddressCardViewModel()
                {
                    AddressCardId = AddrCard.AddressCardId,
                    UserId = userId,
                    FullName = AddrCard.FullName,
                    phoneNumber = AddrCard.phoneNumber,
                    address = AddrCard.address,
                    CityId = AddrCard.CityId,
                    City = AddrCard.City,
                    DistricstId = AddrCard.DistricstId,
                    Districst = AddrCard.Districst,
                    WardsId = AddrCard.WardsId,
                    Ward = AddrCard.Ward,
                    status = AddrCard.status,
                    isDefault = AddrCard.isDefault
                }).ToList();

                return new RequestSuccessResult<List<AddressCardViewModel>>(AddressCard);
            }
            catch (Exception e)
            {
                return new RequestErrorResult<List<AddressCardViewModel>>(e.Message);
            }
        }

        public async Task<RequestResult<bool>> CreateNewAddressCardAsync(AddressCardViewModel request)
        {
            try
            {
                var ward = _projectDbContext.Wards.Where(w => w.CityId == request.CityId && w.DistrictId == request.DistricstId&&w.Id==request.WardsId).Select(w=>w.Name).First();
                var city = _projectDbContext.Cities.Where(c => c.CityId==request.CityId).Select(c => c.Name).First();
                var district = _projectDbContext.Districts.Where(d=> d.CityId == request.CityId&&d.Id==request.DistricstId).Select(d => d.Name).First();
                if (request.isDefault)
                {
                    setDefaultAddressCardAsync(request.UserId);
                }
                var addressCard = new Address()
                {
                    UserId = request.UserId,
                    CityId = request.CityId,
                    City = city,
                    DistricstId = request.DistricstId,
                    Districst = district,
                    WardsId = request.WardsId,
                    Ward = ward,
                    FullName = request.FullName,
                    phoneNumber = request.phoneNumber,
                    address = request.address,
                    isDefault = request.isDefault,
                    status=AddressStatus.Inactive
                };
                _projectDbContext.Addresses.Add(addressCard);
                await _projectDbContext.SaveChangesAsync();
               
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }
        public bool setDefaultAddressCardAsync(string UserId)
        {
            try
            {
                var AddrCards = _projectDbContext.Addresses.Where(addr => addr.UserId == UserId);
                foreach (var item in AddrCards)
                {
                    item.isDefault = false;
                }
                 _projectDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }
        /*public bool setInactiveAddressCardAsync(string UserId)
        {
            try
            {
                var AddrCards = _projectDbContext.Addresses.Where(addr => addr.UserId == UserId);
                foreach (var item in AddrCards)
                {
                    item.status = AddressStatus.Inactive;
                }
                _projectDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }*/
        public  RequestResult<bool> EditAddressCard(AddressCardViewModel request)
        {
            try
            {
                var ward = _projectDbContext.Wards.Where(w => w.CityId == request.CityId && w.DistrictId == request.DistricstId && w.Id == request.WardsId).Select(w => w.Name).First();
                var city = _projectDbContext.Cities.Where(c => c.CityId == request.CityId).Select(c => c.Name).First();
                var district = _projectDbContext.Districts.Where(d => d.CityId == request.CityId && d.Id == request.DistricstId).Select(d => d.Name).First();
                var addrCard = _projectDbContext.Addresses.Where(addr => addr.AddressCardId == request.AddressCardId).First();
                if (request.isDefault)
                {
                    setDefaultAddressCardAsync(request.UserId);
                }
                addrCard.CityId = request.CityId;
                addrCard.City = city;
                addrCard.DistricstId = request.DistricstId;
                addrCard.Districst = district;
                addrCard.WardsId = request.WardsId;
                addrCard.Ward = ward;
                addrCard.FullName = request.FullName;
                addrCard.phoneNumber = request.phoneNumber;
                addrCard.address = request.address;
                addrCard.isDefault = request.isDefault;
                _projectDbContext.SaveChanges();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }

        public RequestResult<AddressCardViewModel> GetAddressCard(int addresscardId=0, string userId=null, string condition=null)
        {
            try
            {
                var AddrCard = new Address();
                if (addresscardId != 0)
                {
                    AddrCard = _projectDbContext.Addresses.Where(add => add.AddressCardId == addresscardId).First();
                }
                else if (addresscardId==0&& condition!=null)
                {
                    if (condition=="active")
                    {
                        AddrCard = _projectDbContext.Addresses.Where(add => add.UserId==userId&&add.isDefault==true).First();
                    }
                }

                
                var result = new AddressCardViewModel()
                {
                    AddressCardId = AddrCard.AddressCardId,
                    UserId = AddrCard.UserId,
                    FullName = AddrCard.FullName,
                    phoneNumber = AddrCard.phoneNumber,
                    address = AddrCard.address,
                    CityId = AddrCard.CityId,
                    City = AddrCard.City,
                    DistricstId = AddrCard.DistricstId,
                    Districst = AddrCard.Districst,
                    WardsId = AddrCard.WardsId,
                    Ward = AddrCard.Ward,
                    status = AddrCard.status,
                    isDefault = AddrCard.isDefault
                };

                return new RequestSuccessResult<AddressCardViewModel>(result);
            }
            catch (Exception e)
            {
                return new RequestErrorResult<AddressCardViewModel>(e.Message);
            }
        }

        public RequestResult<bool> SetActiveAddressCard(int addressCardId)
        {
            try
            {
                var AddressCard = _projectDbContext.Addresses.Where(x => x.AddressCardId == addressCardId).FirstOrDefault();
                
                setDefaultAddressCardAsync(AddressCard.UserId);
                AddressCard.isDefault = true;
                _projectDbContext.SaveChanges();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }

        public RequestResult<List<NotificationViewModel>> GetNotification(string userId)
        {
            try
            {
                var result = _projectDbContext.Notifications.Where(n => n.UserId == userId).Select(n => n).OrderBy(n=>n.Status).ThenByDescending(n=>n.date);
                var news = result.Select(n => new NotificationViewModel()
                {
                    Id = n.Id,
                    UserId = n.UserId,
                    date = n.date,
                    Type = n.Type,
                    Status=n.Status,
                    Targetint = n.Targetint,
                    Targetstr=n.Targetstr,
                    content = n.content
                }).ToList();
                return new RequestSuccessResult<List<NotificationViewModel>>(news);
            }
            catch (Exception e)
            {

                return new RequestErrorResult<List<NotificationViewModel>>(e.Message);
            }
        }

        public RequestResult<bool> UpdateNotificationStatus(int noticationId, bool ApplyforAll)
        {
            try
            {
                if (ApplyforAll)
                {

                }
                else
                {
                    var result = _projectDbContext.Notifications.Where(n => n.Id == noticationId).Select(n => n).FirstOrDefault();
                    result.Status = NotificationStatus.read;
                    _projectDbContext.SaveChanges();
                    return new RequestSuccessResult<bool>();
                }
                return new RequestErrorResult<bool>("false");
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }

        public RequestResult<bool> DeleteNotification(int noticationId, bool ApplyforAll)
        {
            try
            {
                if (ApplyforAll)
                {

                }
                else
                {
                    var notify = _projectDbContext.Notifications.Where(n => n.Id == noticationId).Select(n => n).FirstOrDefault();
                    _projectDbContext.Notifications.Remove(notify);
                    _projectDbContext.SaveChanges();
                }
                return new RequestResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }
    }
}
