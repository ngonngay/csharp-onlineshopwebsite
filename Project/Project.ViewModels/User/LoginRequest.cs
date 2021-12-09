using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.User
{
    public class LoginRequest
    {
        
        [Required(ErrorMessage = "Không để trống")]
        [Display(Name = "Nhập username hoặc email của bạn")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Nhập đúng thông tin")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Nhớ thông tin đăng nhập?")]
        public bool RememberMe { get; set; }
    }
}
