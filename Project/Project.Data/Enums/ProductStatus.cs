using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Enums
{
    public enum ProductStatus
    {
        [Display(Name = "Mới")]
        New,
        [Display(Name = "Đang Bán")]
        Selling,
        [Display(Name = "Ngừng Bán")]
        StopSell,
        [Display(Name = "Hết Hàng")]
        OutOfStock
    }
}
