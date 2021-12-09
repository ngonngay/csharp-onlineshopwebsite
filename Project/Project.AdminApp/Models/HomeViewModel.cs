
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Models
{
    public class HomeViewModel
    {
        //public List<SlideViewModel> Slides { get; set; }


        public List<ProductViewModel> FeaturedProducts { get; set; }

        public List<ProductViewModel> LatestProducts { get; set; }
        public ProductViewModel LandingProduct { get; set; }
        public List<ProductViewModel> RelatedProducts { get; set; }
    }
}