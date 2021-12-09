using Project.ViewModels.cart;
using Project.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Sales
{
    public interface ICartService
    {
        RequestResult<CartViewModel> GetCart(string userId);
        RequestResult<bool> UpdateQuantityInCart(CartUpdateRequest request);
        RequestResult<bool> AddNewItemToCart(CartAddNewItemRequest request);
        RequestResult<bool> CreateOrder(string userId);
    }
}
