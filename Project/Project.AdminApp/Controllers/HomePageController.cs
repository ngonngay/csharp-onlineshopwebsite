using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Project.AdminApp.Models;
using Project.Application.Binder;
using Project.Application.Catalog.Categories;
using Project.Application.Catalog.Products;
//using Project.Controllers;
using Project.ViewModels.common;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{
    public class HomePageController : Controller
    {
        const int Product_PER_PAGE = 9;
        private readonly ILogger<HomePageController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomePageController(ILogger<HomePageController> logger, IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string keyword, int? categoryId, int? id, int pageIndex = 1, int pageSize = 10)
        {
            
            var viewModel = new HomeViewModel
            {
                //Slides = await _slideApiClient.GetAll(),
                FeaturedProducts = await _productService.GetFeaturedProducts(),
                LatestProducts = await _productService.GetLatestProducts(),
            };
            /*foreach (var item in viewModel.FeaturedProducts)
            {
                foreach (var image in item.ProductImages)
                {
                    if (image.IsDefault)
                    {
                        item.ThumbnailImage = image.ImagePath;
                        break;
                    }
                }
            }
            foreach (var item in viewModel.LatestProducts)
            {
                foreach (var image in item.ProductImages)
                {
                    if (image.IsDefault)
                    {
                        item.ThumbnailImage = image.ImagePath;
                        break;
                    }
                }
            }*/
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetail(int id)
        {
            var viewModel = new HomeViewModel
            {
                LatestProducts = await _productService.GetLatestProducts(),
                FeaturedProducts = await _productService.GetFeaturedProducts(),
                LandingProduct = await _productService.GetById(id)
            };
            _productService.AddViewCount(id);
            
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> ListProduct(string listType,string keyword ,decimal? StartPrice,decimal? EndPrice,int? categoryId, int pageIndex = 1, int pageSize = 9)
        {
            bool searchByRangePrice = false;
            if (StartPrice!=null)
            {
                searchByRangePrice = true;
            }
            var request = new GetProductPagingRequest()
            {
                keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                categoryId = categoryId,
                StartPrice=StartPrice,
                EndPrice=EndPrice,
                searchByPrice=searchByRangePrice,
                listType=listType
                
            };
                ViewBag.listType = listType;
                ViewBag.keyword = keyword;
                ViewBag.StartPrice = StartPrice.ToString();
                ViewBag.EndPrice = EndPrice.ToString(); 
                ViewBag.categoryId = categoryId.ToString();
                
                
            PageResult<ProductViewModel> products = await _productService.GetAllPaging(request);
            List<ProductViewModel> FeaturedProducts =await _productService.GetFeaturedProducts();
            ProductsPageViewModel productsPageViewModel = new ProductsPageViewModel()
            {
                FeaturedProducts = FeaturedProducts,
                products = products
            };
            return View(productsPageViewModel);
        }
    }
}
