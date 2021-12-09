using Project.ViewModels.common;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Models
{
    public class ProductsPageViewModel
    {
        public List<ProductViewModel> FeaturedProducts { get; set; }
        public List<ProductViewModel> LatestProducts { get; set; }
        public PageResult<ProductViewModel> products { get; set; }

    }
}
