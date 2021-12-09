using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalog.Users;
using Project.Application.Sales;
using Project.Data.Entities;
using Project.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Areas.Identity.Pages.Account.Manage
{
    public partial class OrderDetailModel:PageModel
    {
       
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IOrderService _orderservice;

        public OrderDetailModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService, IOrderService orderservice)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _orderservice = orderservice;
        }
        [TempData]
        public string StatusMessage { get; set; }
        public OrderViewModel order { get; set; }
       
        public IActionResult OnGet(int id)
        {
            var result=_orderservice.GetOrderById(id);
            if (result.IsSuccessed)
            {
                order = result.ResultObj;
            }
            return Page();
        }
    }
}
