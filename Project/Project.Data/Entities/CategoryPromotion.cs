using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class CategoryPromotion
    {
        public int PromotionId { get; set; }
        public int CategoryId { get; set; }
        public Promotion Promotion { get; set; }
        public Category Category { get; set; }
    }
}
