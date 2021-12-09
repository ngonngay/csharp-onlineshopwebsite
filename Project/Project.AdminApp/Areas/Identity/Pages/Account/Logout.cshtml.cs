using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project.Data.Entities;
using Project.Views.Shared.Components.MessagePage;

namespace Project.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<AppUser> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            if (!_signInManager.IsSignedIn(User)) return RedirectToPage("/Index");

            await _signInManager.SignOutAsync();
            _logger.LogInformation("Người dùng đăng xuất");


            return ViewComponent(MessagePage.COMPONENTNAME,
                new MessagePage.Message()
                {
                    title = "Đã đăng xuất",
                    htmlcontent = "Đăng xuất thành công",
                    urlredirect = (returnUrl != null) ? returnUrl : Url.Page("/Index")
                }
            );
        }
        public async Task<IActionResult> OnGet(string returnUrl = null)
        {
            if (!_signInManager.IsSignedIn(User)) return RedirectToPage("/Index");

            await _signInManager.SignOutAsync();
            _logger.LogInformation("Người dùng đăng xuất");


            return ViewComponent(MessagePage.COMPONENTNAME,
                new MessagePage.Message()
                {
                    title = "Đã đăng xuất",
                    htmlcontent = "Đăng xuất thành công",
                    urlredirect = (returnUrl != null) ? returnUrl : Url.Page("/Index")
                }
            );
        }
    }
} 

