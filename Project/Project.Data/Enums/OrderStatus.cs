using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Data.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "Mới")]
        New,
        [Display(Name = "Đã Xác Nhận")]
        Confirmed,
        [Display(Name = "Đang đóng gói")]
        InProgress,
        [Display(Name = "Đang Vận Chuyển")]
        Shipping,
        [Display(Name = "Thành Công")]
        Success,
        [Display(Name = "Đã Hủy")]
        Canceled
    }
}
