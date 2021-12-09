using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Data.Enums
{
    public enum Status
    {
        [Display(Name="Không Khả Dụng")]
        InActive,
        [Display(Name ="Khả Dụng")]
        Active
    }
}
