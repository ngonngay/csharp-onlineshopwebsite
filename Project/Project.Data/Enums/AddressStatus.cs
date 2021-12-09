using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Data.Enums
{

    public enum AddressStatus
    {
        [Display(Name = "Đang chọn")]
        Active,
        [Display(Name = "Không Chọn")]
        Inactive
    }
}
