using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels.cart
{
    public class CartItemViewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }
    }
}