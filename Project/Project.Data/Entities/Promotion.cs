
using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
    public class Promotion
    {
        public int Id { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public string ApplyCode { get; set; }
        public bool ApplyForAll { set; get; }
        public bool ApplyForProductIds { set; get; }
        public bool ApplyForCategoryIds { set; get; }
        public bool ApplyForOrderTotal { get; set; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public int? ProductsPromotionId { set; get; }
        public int? CategoriesPromotionId { set; get; }
        public int? quantity { get; set; }
        public Status Status { set; get; }
        public string Description { get; set; }
        public string Name { set; get; }
        public decimal? MaximumDiscountAmountForPecentCoupon { get; set; }
        public int? MaximumDiscountPercentForAmountCoupon { get; set; }
        public decimal? MinimumTotalOrder { get; set; }
        public List<ProductPromotion> productsPromotion { get; set; }
        public List<CategoryPromotion> categoriesPromotion { get; set; }
    }
}
