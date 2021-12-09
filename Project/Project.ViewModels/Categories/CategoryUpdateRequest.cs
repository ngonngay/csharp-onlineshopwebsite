using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Categories
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        [Display(Name = "Tên Danh Mục")]
        public string Name { get; set; }
        [Display(Name = "Mô Tả")]
        public string Description { set; get; }
        [Display(Name = "Độ Ưu Tiên")]
        public int SortOrder { set; get; }
        [Display(Name = "Hiển Thị Ở Trang Chủ")]
        public bool IsShowOnHome { set; get; }
        [Display(Name = "Danh Mục Cha")]
        public int? ParentId { set; get; }
        [Display(Name = "Trạng Thái")]
        public Status Status { set; get; }
    }
}
