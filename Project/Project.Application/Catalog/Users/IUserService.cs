using Project.ViewModels.common;
using Project.ViewModels.Notification;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Application.Catalog.Users
{
    public interface IUserService
    {
        Task<PageResult<UserViewModel>> GetAllUser(string role);
        Task<UserViewModel> GetById(String id);
        Task<bool> Delete(string id);
        RequestResult<List<AddressCardViewModel>> GetAddressCard(string userId, string orderby = null);
        RequestResult<AddressCardViewModel> GetAddressCard(int addresscardId=0, string userId=null, string condition=null);
        Task<RequestResult<bool>> CreateNewAddressCardAsync(AddressCardViewModel request);
        RequestResult<bool> EditAddressCard(AddressCardViewModel request);
        RequestResult<bool> SetActiveAddressCard(int addressCardId);
        RequestResult<List<NotificationViewModel>> GetNotification(string userId);
        RequestResult<bool> UpdateNotificationStatus(int noticationId,bool ApplyforAll);
        RequestResult<bool> DeleteNotification(int noticationId, bool ApplyforAll);
    }
}
