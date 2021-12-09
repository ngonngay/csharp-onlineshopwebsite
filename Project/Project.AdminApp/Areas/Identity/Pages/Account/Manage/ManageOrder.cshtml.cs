using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalog.Users;
using Project.Application.Sales;
using Project.Data.Entities;
using Project.ViewModels.common;
using Project.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using System.Threading.Tasks;

namespace Project.AdminApp.Areas.Identity.Pages.Account.Manage
{
    public partial class ManageOrderModel : PageModel
    {
        const int ORDER_PER_PAGE = 10;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IOrderService _orderservice;

        public ManageOrderModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService, IOrderService orderservice)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _orderservice = orderservice;
        }
        [TempData]
        public string StatusMessage { get; set; }
        [BindProperty(SupportsGet = true)]
        public int pageNumber { set; get; }
        public int totalPages { set; get; }
        public List<OrderViewModel> Orders {get;set;}
        public IActionResult OnGet()
        {

            var result = _orderservice.GetAllOrder(_userManager.GetUserId(User));
            if (result.IsSuccessed)
            {
                if (pageNumber == 0)
                    pageNumber = 1;

                var orders = result.ResultObj;

                int totalOrder = orders.Count();


                totalPages = (int)Math.Ceiling((double)totalOrder / ORDER_PER_PAGE);

                Orders =  orders.Skip(ORDER_PER_PAGE * (pageNumber - 1)).Take(ORDER_PER_PAGE).ToList();
                return Page();
            }

            return Page();
        }
        public IActionResult OnPostCancleOrder(int id,string reason)
        {
           /* var result = _orderService.UpdateStatus(OrderId, selectedStatus, reason);
            if (result.IsSuccessed)
            {*/
                return new JsonResult (new { result = "success" }); 
            //}
            //return Json(new { result = "fasle" });
            //return Redirect("./ManageOrder");
        }
    }
}
