using Microsoft.AspNetCore.Http;
using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.ViewModels.Products
{
    public class ProductUpdateRequest
    {
        public ProductUpdateRequest()
        {
            Images = new List<IFormFile>();
        }
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }

        public decimal Price { set; get; }
        public int Stock { set; get; }
        [Display(Name="Sản Phẩm Nổi Bật")]
        public bool IsFeatured { get; set; }
        public ProductStatus productStatus { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        public List<IFormFile> Images { get; set; }
        
    }
}