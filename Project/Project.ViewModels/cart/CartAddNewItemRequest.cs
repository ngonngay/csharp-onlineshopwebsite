using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.cart
{
    public class CartAddNewItemRequest
    {
        public int id { get; set; }
        public int productId { get; set; }
        public ClaimsPrincipal principal { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
