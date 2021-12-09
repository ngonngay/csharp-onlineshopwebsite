using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Enums
{
    public enum NotificationStatus
    {
        [Display(Name = "Mới")]
        New,
        [Display(Name = "Đã Đọc")]
        read
    }
}
