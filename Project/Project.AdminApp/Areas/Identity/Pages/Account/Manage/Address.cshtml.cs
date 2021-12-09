using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalog.Users;
using Project.Data.Entities;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Areas.Identity.Pages.Account.Manage
{
    public partial class AddressModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;

        public AddressModel( UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }
        public List<AddressCardViewModel> addressCard { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        public  IActionResult OnGet()
        {
            var result= _userService.GetAddressCard(_userManager.GetUserId(User));
            if (result.IsSuccessed)
            {
                addressCard = result.ResultObj;
            }
            return Page();
        }
    } 
}
