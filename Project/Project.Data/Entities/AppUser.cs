using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
   
        public class AppUser : IdentityUser
        {
            //public string UserName { get; set; }
            public string Address { get; set; }

            public string FullName { get; set; }
        
            public DateTime Birthday { get; set; }

            public List<Cart> Carts { get; set; }

            public List<Order> Orders { get; set; }

            public bool disable { get; set; }
            
            public DateTime LastSignIn { get; set; }

            public List<Address> Addresses { get; set; }
            public List<Notification> notifications { get; set; }

            //public List<Transaction> Transactions { get; set; }
        }
    
}
