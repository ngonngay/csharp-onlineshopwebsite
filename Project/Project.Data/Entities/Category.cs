using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public int SortOrder { set; get; }

        public bool IsShowOnHome { set; get; }

        public int? ParentId { set; get; }

        public Status Status { set; get; }

        public List<Product> Products { get; set; }
        public List<CategoryPromotion> CategoryPromotions { get; set; }
    }
}
