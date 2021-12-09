
using Project.ViewModels.Categories;
using Project.ViewModels.common;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PageResult<ProductViewModel> Products { get; set; }
    }
}