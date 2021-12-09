using Project.ViewModels.common;
using Project.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Sales
{
    public interface IOrderService
    {
        RequestResult<PageResult<OrderViewModel>> GetAllOrder(GetOrderPagingRequest request);
        RequestResult<List<OrderViewModel>> GetAllOrder(string userId);
        RequestResult<OrderViewModel> GetOrderById(int orderId);
        RequestResult<bool> UpdateStatus(int orderId, int selectedStatus, string reason=null);
        RequestResult<ReportViewModel> GetReport();
    }
}
