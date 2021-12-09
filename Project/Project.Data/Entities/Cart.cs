using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public string size { get; set; }
       
        public string UserId { get; set; }

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; } 
        public DateTime LastModify { get; set; } 

        public AppUser AppUser { get; set; }
    }
}
