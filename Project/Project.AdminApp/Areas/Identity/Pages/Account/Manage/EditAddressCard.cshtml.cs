using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Catalog.Users;
using Project.Data.Entities;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Areas.Identity.Pages.Account.Manage
{
    public partial class EditAddressModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;

        public EditAddressModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }
        [FromRoute]
        public int AddressCardId { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Vui Lòng chọn Tỉnh/Thành Phố")]
        public string cityId { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Vui Lòng chọn Quận/Huyện")]
        public string districtId { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Vui Lòng chọn Phường/Xã")]
        public string wardId { get; set; }

        public AddressCardViewModel addressCardViewModel { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public bool isDefault { get; set; }
        public class InputModel
        {
            [Phone]
            [Display(Name = "Số điện thoại")]
            public string PhoneNumber { get; set; }

            [MaxLength(100)]
            [Display(Name = "Họ tên ")]
            public string FullName { set; get; }

            [MaxLength(255)]
            [Display(Name = "Địa chỉ")]
            [Required(ErrorMessage = "Vui Lòng Nhập địa chỉ chi tiết")]
            public string Address { set; get; }


        }
        private async Task LoadAsync(AppUser user)
        {
           
            Input = new InputModel();
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Không tải được tài khoản ID = '{_userManager.GetUserId(User)}'.");
            }
            var resultRequest= _userService.GetAddressCard(AddressCardId, _userManager.GetUserId(User));
            if (resultRequest.IsSuccessed)
            {
                addressCardViewModel = resultRequest.ResultObj;
                isDefault = addressCardViewModel.isDefault;
            }
            await LoadAsync(user);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var request = new AddressCardViewModel()
            {
                AddressCardId=AddressCardId,
                FullName = Input.FullName,
                phoneNumber = Input.PhoneNumber,
                address = Input.Address,
                CityId = cityId,
                DistricstId = districtId,
                WardsId = wardId,
                isDefault = isDefault,
                UserId = _userManager.GetUserId(User)
            };
            var result =  _userService.EditAddressCard(request);
            if (result.IsSuccessed)
            {
                StatusMessage = "Cập Nhật thành công";
                return RedirectToPage("Address");
            }
            return Page();
        }
    }
}
