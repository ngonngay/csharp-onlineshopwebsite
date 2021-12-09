using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Project.Application.Binder;
using Project.Application.Catalog.Categories;
using Project.Application.Catalog.Products;
using Project.Data.Entities;
using Project.Models;
using Project.ViewModels.common;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(ILogger<HomeController> logger,IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string keyword, int? categoryId, int? id, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetProductPagingRequest()
            {
                keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                categoryId = categoryId,
                id = id
            };
            PageResult<ProductViewModel> products = await _productService.GetAllPaging(request);
            foreach(var item in products.Items)
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
            var categories = await _categoryService.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.Id
            });
            ViewBag.Keyword = keyword;
            ViewBag.id = id;
            ViewBag.categoryid = categoryId;
            return View(products);
            
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetail(int id)
        {
            var result = await _productService.GetById(id);
            result.status = result.productStatus.DisplayName();
            return View(result);
        }
    }
}
