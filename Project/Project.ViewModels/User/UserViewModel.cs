using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.User
{
    public class UserViewModel
    {

        public string Id { get; set; }

        [Display(Name = "Tên")]
        
        public string Fullname { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name ="Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime Birthday { get; set; }
        [Display(Name ="Trạng thái kích hoạt")]
        public string EmailConfirmed { get; set; }
        public string Disable { get; set; }
        public int totalOrder { get; set; }
        /*
Id
UserName
Email
PhoneNumber
Address
Fullname
Birthday
*/

    }
}
