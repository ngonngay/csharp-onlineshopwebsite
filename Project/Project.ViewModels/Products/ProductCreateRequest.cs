using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Project.Data.Enums;

namespace Project.ViewModels.Products
{
    public class ProductCreateRequest
    {
        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]
        [Display(Name = "Giá")]
        public decimal Price { set; get; }
        [Required(ErrorMessage = "Bạn phải nhập số lượng sản phẩm")]
        [Display(Name = "Số Lượng")]
        public int Stock { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [Display(Name = "Tên")]
        public string Name { set; get; }

        public string Description { set; get; }

        public string Details { set; get; }
        
        public string LanguageId { set; get; }

        public int categoryId { set; get; }
        [Display(Name ="Sản Phẩm Nổi Bật")]
        public bool IsFeatured { get; set; }

        public ProductStatus status { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
