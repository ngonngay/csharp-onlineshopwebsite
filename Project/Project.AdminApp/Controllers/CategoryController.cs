using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Binder;
using Project.Application.Catalog.Categories;
using Project.Application.Catalog.Products;
using Project.Data.Enums;
using Project.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public CategoryController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAll();
            
            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _categoryService.GetById(id);
            var categoryUpdateRequest = new CategoryUpdateRequest()
            {
                Id = result.Id,
                Name = result.Name,
                IsShowOnHome = result.IsShowOnHome,
                Status = result.Status,
                SortOrder = result.SortOrder
            };
            ViewBag.Status=Enum.GetValues(typeof(Status)).Cast<Status>().Select(v => new SelectListItem
            {
                Text = v.DisplayName(),
                Value = ((int)v).ToString(),
                Selected=result.Status==v
            }).ToList();
            return View(categoryUpdateRequest);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] CategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _categoryService.UpdateCategory(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật danh mục thất bại\n"+result.Message);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Status = Enum.GetValues(typeof(Status)).Cast<Status>().Select(v => new SelectListItem
            {
                Text = v.DisplayName(),
                Value = ((int)v).ToString()
            }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _categoryService.Create(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Thêm mới danh mục thành công";
                return RedirectToAction("Index");
            }
  
            ModelState.AddModelError("", "Thêm danh mục thất bại");
            return View(request);

        }
    }
}
