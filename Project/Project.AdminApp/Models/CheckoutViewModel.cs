
using Project.ViewModels.cart;
using Project.ViewModels.Sales;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Models
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public CheckoutRequest CheckoutModel { get; set; }
        public AddressCardViewModel addressCardViewModel { get; set; }
    }
}