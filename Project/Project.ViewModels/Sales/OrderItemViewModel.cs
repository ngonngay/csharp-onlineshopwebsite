using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Sales
{
    public class OrderItemViewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }
        public string Size { get; set; }
        public decimal total { get { return Price * Quantity; }set { total = value; } }
        public decimal Price { get; set; }
    }
}
