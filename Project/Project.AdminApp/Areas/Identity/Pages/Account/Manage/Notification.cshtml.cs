using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalog.Users;
using Project.Application.Sales;
using Project.Data.Entities;
using Project.ViewModels.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Areas.Identity.Pages.Account.Manage
{
    public partial class NotificationModel :PageModel
    {
        const int Notify_PER_PAGE = 10;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IOrderService _orderservice;

        public NotificationModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService, IOrderService orderservice)
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
        public List<NotificationViewModel> notificationViewModels { get; set; }
        //public List<NotificationViewModel> Orders { get; set; }
        public IActionResult OnGet()
        {
            var result=_userService.GetNotification(_userManager.GetUserId(User));
            if (result.IsSuccessed)
            {
                if (pageNumber == 0)
                    pageNumber = 1;
                var news= result.ResultObj;
                int totalOrder = news.Count();


                totalPages = (int)Math.Ceiling((double)totalOrder / Notify_PER_PAGE);

                notificationViewModels = news.Skip(Notify_PER_PAGE * (pageNumber - 1)).Take(Notify_PER_PAGE).ToList();
                 
                
            }
            return Page();
        }
       
    }
}
