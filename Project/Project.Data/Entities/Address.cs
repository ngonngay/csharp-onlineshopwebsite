using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Address
    {
        public int AddressCardId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string UserId { get; set; }
        public AddressStatus status { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public  string CityId { get; set; }
        public  string City { get; set; }
        public string DistricstId { get; set; }
        public string Districst { get; set; }
        public string WardsId { get; set; } 
        public string Ward { get; set; } 
        public bool isDefault { get; set; }
        public AppUser appUser { get; set; }
    }
}
