using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class ProductPromotion
    {
        public int PromotionId { get; set; }
        public int ProductId { get; set; }
        public Promotion Promotion { get; set; }
        public Product Product { get; set; }
    }
}
