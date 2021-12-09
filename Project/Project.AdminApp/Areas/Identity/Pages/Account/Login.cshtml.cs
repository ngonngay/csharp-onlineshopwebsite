using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Project.Data.Entities;
using Project.Views.Shared.Components.MessagePage;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace Project.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IEmailSender _emailSender;
        public LoginModel(SignInManager<AppUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<AppUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Không để trống")]
            [Display(Name = "Nhập username hoặc email của bạn")]
            [StringLength(100, MinimumLength = 1, ErrorMessage = "Nhập đúng thông tin")]
            public string UserNameOrEmail { set; get; }

            [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
            [DataType(DataType.Password)]
            [Display(Name = "Mật khẩu")]
            public string Password { get; set; }

            [Display(Name = "Nhớ thông tin đăng nhập?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // Đã đăng nhập nên chuyển hướng về Index
            if (_signInManager.IsSignedIn(User)) return Redirect("Index");

            if (ModelState.IsValid)
            {

                IdentityUser user = await _userManager.FindByEmailAsync(Input.UserNameOrEmail);
                if (user == null)
                    user = await _userManager.FindByNameAsync(Input.UserNameOrEmail);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Tài khoản không tồn tại.");
                    return Page();
                }
                
                var result = await _signInManager.PasswordSignInAsync(
                        user.UserName,
                        Input.Password,
                        Input.RememberMe,           // Có lưu cookie - khi đóng trình duyệt vẫn nhớ
                        true                        // CÓ ÁP DỤNG LOCKOUT
                    );


                if (result.Succeeded)
                {
                    _logger.LogInformation("User đã đăng nhập");
                    return ViewComponent(MessagePage.COMPONENTNAME, new MessagePage.Message()
                    {
                        title = "Đã đăng nhập",
                        htmlcontent = "Đăng nhập thành công",
                        urlredirect = returnUrl
                    });
                }
                if (result.RequiresTwoFactor)
                {
                    // Nếu cấu hình đăng nhập hai yếu tố thì chuyển hướng đến LoginWith2fa
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("Tài khoản bí tạm khóa.");
                    // Chuyển hướng đến trang Lockout - hiện thị thông báo
                    return RedirectToPage("./Lockout");
                }
                else
                {
                   
                    if (!user.EmailConfirmed)
                    {
                        // phát sinh token theo thông tin user để xác nhận email
                        // mỗi user dựa vào thông tin sẽ có một mã riêng, mã này nhúng vào link
                        // trong email gửi đi để người dùng xác nhận

                        var code = await _userManager.GenerateEmailConfirmationTokenAsync((AppUser)user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                        // callbackUrl = /Account/ConfirmEmail?userId=useridxx&code=codexxxx
                        // Link trong email người dùng bấm vào, nó sẽ gọi Page: /Acount/ConfirmEmail để xác nhận
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                            protocol: Request.Scheme);

                        // Gửi email    
                        await _emailSender.SendEmailAsync(user.Email, "Xác nhận địa chỉ email",
                            $"Hãy xác nhận địa chỉ email bằng cách <a href='{callbackUrl}'>Bấm vào đây</a>.");
                        //$"Email được gửi từ ứng dụng cho chức năng đăng kí bằng email :)))))) <a href='{callbackUrl}'>Bấm vào đây</a>.");
                        return RedirectToPage("RegisterConfirmation", new { email = user.Email, returnUrl = returnUrl });
                    }

                    ModelState.AddModelError(string.Empty, "Sai tên đăng nhập hoặc mật khẩu");
                    return Page();
                }
            }

            return Page();
        }
    }
}

