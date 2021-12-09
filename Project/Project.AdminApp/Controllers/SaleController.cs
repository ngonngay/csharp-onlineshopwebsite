using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Binder;
using Project.Application.Catalog.Products;
using Project.Application.Sales;
using Project.Data.Enums;
using Project.ViewModels.common;
using Project.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{
    public class SaleController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
            
        public SaleController(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }
        [Authorize(Roles = "Admin,staff")]
        public IActionResult Order(int orderId,string username,string productName, int status = -1, int pageIndex = 1, int pageSize = 10)
        {
            RequestResult<PageResult<OrderViewModel>> result =_orderService.GetAllOrder(new GetOrderPagingRequest()
            {
                OrderId=orderId,
                status=status,
                username=username,
                PageIndex=pageIndex,
                PageSize=pageSize,
                productName=productName
            });
            if (result.IsSuccessed)
            {
                var orders = result.ResultObj;
                ViewBag.orderId = orderId;
                ViewBag.username = username;
                ViewBag.productName = productName;
                ViewBag.Status = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().Select(v => new SelectListItem
                {
                    Text = v.DisplayName(),
                    Value = ((int)v).ToString(),
                    Selected = status ==(int) v
                }).ToList();
                return View(orders);
            };
            return View();
        }
        public IActionResult OrderDetail(int orderId)
        {
            var result = _orderService.GetOrderById(orderId);
            if (result.IsSuccessed)
            {
                var order = result.ResultObj;
                ViewBag.Status = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().Select(v => new SelectListItem
                {
                    Text = v.DisplayName(),
                    Value = ((int)v).ToString(),
                    Selected = order.Status == v
                }).ToList();
                return View(order);
            };
            return View();
        }
        [HttpPost]
        public IActionResult UpdateOrderStatus(int OrderId, int selectedStatus, string reason=null,string returnUrl=null)
        {
            
            var result = _orderService.UpdateStatus(OrderId, selectedStatus, reason);
            if (result.IsSuccessed)
            {
                if (!String.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                
                return Json(new { result = "success" }); 
            }
            return Json(new { result = "fasle"}); 
        }
    }
}
