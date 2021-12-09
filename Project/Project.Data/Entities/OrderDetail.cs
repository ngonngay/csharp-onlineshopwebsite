using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public string productName { get; set; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public string size { get; set; }
        public decimal total { get; set; }
        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
