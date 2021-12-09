using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.cart
{
    public class CartViewModel
    {
        public int id { get; set; }
        public string UserId { get; set; }
        public List<CartItemViewModel> cartItem { get; set; } = new List<CartItemViewModel>();

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }

    }
}
