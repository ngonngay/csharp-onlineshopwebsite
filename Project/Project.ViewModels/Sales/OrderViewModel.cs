using Project.Data.Enums;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Sales
{
    public class OrderViewModel
    {
        public int OrderId { set; get; }
        public DateTime OrderDate { set; get; }
        public UserViewModel User { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public decimal ShippingFee { get; set; }
        public OrderStatus Status { set; get; }
        public string CityId { get; set; }
        public string City{ get; set; }
        public string DistricstId { get; set; }
        public string Districst { get; set; }
        public string WardsId { get; set; }
        public string Wards { get; set; }
        public string CustomerNote { get; set; }
        public string StaffNote { get; set; }
        public Decimal total { get; set; }
        public string cancleReason { get; set; }
        public List<OrderItemViewModel> ordertItem { get; set; } = new List<OrderItemViewModel>();
        
    }
}
