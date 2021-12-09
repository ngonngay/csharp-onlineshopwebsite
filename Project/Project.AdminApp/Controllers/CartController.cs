using System;

using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.ViewModels.cart;
using Project.AdminApp.Models;
using Project.Application.Catalog.Products;
using Project.Application.Exceptions;
using Project.Data.Entities;
using Project.ViewModels.Sales;
using Project.Application.Sales;
using System.IO;
using Newtonsoft.Json.Linq;
using Project.Application.Catalog.Users;
using Project.ViewModels.common;

namespace Project.AdminApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;

        public CartController(IProductService productService, ICartService cartService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService)
        {
            _productService = productService;
            _signInManager = signInManager;
            _userManager = userManager;
            _cartService = cartService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            if (_signInManager.IsSignedIn(principal))
            {
                var result = _userService.GetAddressCard(0, _userManager.GetUserId(principal), "active");
                if (result.IsSuccessed)
                {
                    return View(result.ResultObj);
                }
            }
            return View();
        }

        public IActionResult Checkout()
        {
            var model = new CheckoutViewModel();
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var result = _userService.GetAddressCard(0, _userManager.GetUserId(principal), "active");
            if (result.IsSuccessed)
            {
                model.addressCardViewModel = result.ResultObj;
                return View(model);
            }
            else
            {
                ViewBag.Message = "Trước Tiên Hãy Tạo Một Địa Chỉ Mới";
                return Redirect("/customer/address/create");
            }
            

        }

        [HttpPost]
        public IActionResult Checkout(CheckoutViewModel request)
        {
            var model = GetCheckoutViewModel();
            var orderDetails = new List<OrderDetailVm>();
            foreach (var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailVm()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                });
            }
            var checkoutRequest = new CheckoutRequest()
            {
                Address = request.CheckoutModel.Address,
                Name = request.CheckoutModel.Name,
                Email = request.CheckoutModel.Email,
                PhoneNumber = request.CheckoutModel.PhoneNumber,
                OrderDetails = orderDetails
            };
            //TODO: Add to API
            TempData["SuccessMsg"] = "Order puschased successful";
            return View(model);
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            //get cart from sesion
            CartViewModel SessionCart = new CartViewModel();
            CartViewModel ResetSessionCart = new CartViewModel();
            if (session != null)
                SessionCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);//lấy cart từ session
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var result = _signInManager.IsSignedIn(principal);
            if (result)//đã đăng nhập thì lấy cart ở trong db rồi đồng bộ với cart trong session
            {
                //xử lí lấy cart từ db, 
                var userid = _userManager.GetUserId(principal);
                var getCartResult = _cartService.GetCart(userid);
                //end request db-cart
                
                //synchronize session cart with dbcart
                if (getCartResult.IsSuccessed) // đã đăng nhập và có cart trong db
                {
                    var UserCart = getCartResult.ResultObj;//cart trong db
                    if (SessionCart.cartItem != null)//đã có cart trong session
                    {
                        
                        bool exist;
                        foreach (var sessionItem in SessionCart.cartItem)//đồng bộ cart
                        {
                            exist = false;
                            foreach (var userItem in UserCart.cartItem)
                            {
                                if (userItem.ProductId == sessionItem.ProductId && userItem.Size==sessionItem.Size)
                                {
                                    userItem.Quantity += sessionItem.Quantity;
                                    userItem.Price = sessionItem.Price;
                                    exist = true;
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                UserCart.cartItem.Add(sessionItem);
                                //thêm item này vào cart trong db
                                var request = new CartAddNewItemRequest()
                                {
                                    
                                    productId = sessionItem.ProductId,
                                    Quantity = sessionItem.Quantity,
                                    UserId = _userManager.GetUserId(principal),
                                    principal = principal,
                                    Size = sessionItem.Size,
                                    Price = sessionItem.Price
                                };
                                _cartService.AddNewItemToCart(request);
                            }
                        }
                        
                        HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(ResetSessionCart.cartItem));//sau khi đồng bộ thì xóa cart
                    }
                    return Ok(UserCart.cartItem);
                }
                else // đã đăng nhập nhưng chưa có cart trong db
                {
                    if (SessionCart.cartItem != null)//đã đăng nhập, chưa có cart trong db, đã có cart trong session
                    {
                        foreach (var sessionItem in SessionCart.cartItem)
                        {

                            var request = new CartAddNewItemRequest()
                            {

                                productId = sessionItem.ProductId,
                                Quantity = sessionItem.Quantity,
                                UserId = _userManager.GetUserId(principal),
                                principal = principal,
                                Size = sessionItem.Size,
                                Price = sessionItem.Price
                            };
                            _cartService.AddNewItemToCart(request);//thêm cart từ session vào db
                        }
                        HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(ResetSessionCart.cartItem));//sau khi đồng bộ thì xóa cart
                    }
                   
                    return Ok(SessionCart.cartItem);
                }
            }
            //chưa đăng nhập, trả cart từ session 
            return Ok(SessionCart.cartItem);
        }

        public async Task<IActionResult> AddToCart(int id,string size,int quantity=1)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var signIn = _signInManager.IsSignedIn(principal);
            var product = await _productService.GetById(id);
            CartViewModel currentCart = new CartViewModel();
            if (session != null)
                currentCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            if (signIn)
            {
                //xử lí lấy cart từ db, 
                var userid = _userManager.GetUserId(principal);
                var getCartResult = _cartService.GetCart(userid);
                //end request db-cart
                if (getCartResult.IsSuccessed)
                {
                    currentCart = getCartResult.ResultObj;
                }
            }
            //ábdhjasbhjasbdhjasbdbasbhj
            
            if (currentCart.cartItem != null && currentCart.cartItem.Any(x => x.ProductId == id && x.Size == size))
            {
                currentCart.cartItem.First(x => x.ProductId == id && x.Size==size).Quantity += 1;
                if (signIn)
                {
                    var request = new CartUpdateRequest()
                    {
                        id = currentCart.id,
                        productId = id,
                        size = size,
                        Quantity = currentCart.cartItem.First(x => x.ProductId == id).Quantity,
                        UserId = _userManager.GetUserId(principal)
                    };
                     _cartService.UpdateQuantityInCart(request);
                    return Ok(currentCart.cartItem);
                }
            }
            else
            {
                var cartItem = new CartItemViewModel()
                {
                    ProductId = id,
                    Description = product.Description,
                    Image = product.ThumbnailImage,
                    Name = product.Name,
                    Price = product.Price,
                    Size=size,
                    Quantity = quantity
                };
                currentCart.cartItem.Add(cartItem);
                if (signIn)
                {
                    var request = new CartAddNewItemRequest()
                    {
                        id = currentCart.id,
                        productId = id,
                        Quantity = quantity,
                        UserId = _userManager.GetUserId(principal),
                        principal = principal,
                        Size = size,
                        Price = product.Price
                    };
                    _cartService.AddNewItemToCart(request);
                    return Ok(currentCart.cartItem);
                }
            }
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart.cartItem));
            return Ok(currentCart.cartItem);

        }

        public IActionResult UpdateCart(int id, int quantity,string size)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var signIn = _signInManager.IsSignedIn(principal);
            CartViewModel currentCart = new CartViewModel();
            if (session != null)
                currentCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            if (signIn)
            {
                //xử lí lấy cart từ db, 
                var userid = _userManager.GetUserId(principal);
                var getCartResult = _cartService.GetCart(userid);
                //end request db-cart
                if (getCartResult.IsSuccessed)
                {
                    currentCart = getCartResult.ResultObj;
                }
            }

            foreach (var item in currentCart.cartItem)
            {
                if (item.ProductId == id && item.Size==size)
                {
                    if (quantity == 0)
                    {
                        currentCart.cartItem.Remove(item);
                    }
                    item.Quantity = quantity;
                    if (signIn)
                    {
                        var request = new CartUpdateRequest()
                        {
                            id = currentCart.id,
                            size=size,
                            productId = item.ProductId,
                            Quantity = quantity,
                            UserId = _userManager.GetUserId(principal)
                        };
                        _cartService.UpdateQuantityInCart(request);
                        return Ok(currentCart);
                    }
                    break;
                }
            }
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart.cartItem));
            return Ok(currentCart);
        }

        private CheckoutViewModel GetCheckoutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            var checkoutVm = new CheckoutViewModel()
            {
                CartItems = currentCart,
                CheckoutModel = new CheckoutRequest()
            };
            return checkoutVm;
        }
        public IActionResult CreateOrder()
        {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            RequestResult<bool> result= _cartService.CreateOrder(_userManager.GetUserId(principal));
            if (result.IsSuccessed)
            {
                return Ok();
            }
            return NotFound();
        }
        public IActionResult SelectAddressCard()
        {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;

            var result = _userService.GetAddressCard(_userManager.GetUserId(principal),"status");
            if (result.IsSuccessed)
            {
                return View(result.ResultObj);
            }
            return View();
        }
        public IActionResult SetActiveAddressCard(int AddressCardId) {

            var result=_userService.SetActiveAddressCard(AddressCardId);
            if (result.IsSuccessed)
            {
                return RedirectToAction("checkout");
            }
            TempData["result"] = "Error : Đã có lỗi xảy ra, vui lòng thử lại! ";
            return RedirectToAction("SelectAddressCard");
        }
    }
}