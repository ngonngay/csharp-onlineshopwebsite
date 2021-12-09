using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.cart
{
    public class CartUpdateRequest
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public string size { get; set; }
    }
}
