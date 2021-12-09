using Project.Data.Enums;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.ViewModels.Categories
{
    public class CategoryViewModel
    {

        public int Id { get; set; }
        [Display(Name="Tên Danh Mục" )]
        public string Name { get; set; }
        [Display(Name ="Mô Tả")]
        public string Description { set; get; }
        [Display(Name = "Độ Ưu Tiên")]
        public int SortOrder { set; get; }
        [Display(Name = "Hiển Thị Ở Trang Chủ")]
        public bool IsShowOnHome { set; get; }
        [Display(Name = "Danh Mục Cha")]
        public int? ParentId { set; get; }
        [Display(Name = "Trạng Thái")]
        public Status Status { set; get; }
        public List<ProductViewModel> productViewModels { get; set; }
        public List<string> Products { get; set; } = new List<string>();
       
        public bool asigned(int id)
        {
            foreach (var item in productViewModels)
            {
                if (item.Id==id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}