
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.ViewModels.Categories;
using Project.Utilities.Exceptions;
using Project.ViewModels.common;
using Project.Data.Entities;
using Project.ViewModels.Products;

namespace Project.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ProjectDbContext _context;

        public CategoryService(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<RequestResult<bool>> Create(CategoryCreateRequest request)
        {
            string error = null;
            int result = 0;
            try
            {
                var category = new Category()
                    {
                        Name = request.Name,
                        IsShowOnHome = request.IsShowOnHome,
                        Status = request.Status,
                        SortOrder = request.SortOrder
                    };
                 _context.Categories.Add(category);
           
                result = await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                error = e.Message;
            }


            return (result == 1) ? new RequestSuccessResult<bool>() : new RequestErrorResult<bool>(error);
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories.Include(category => category.Products)
                        select c;
            return await query.Select(category => new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                IsShowOnHome= category.IsShowOnHome,
                Status= category.Status,
                SortOrder= category.SortOrder,
                productViewModels= category.Products.Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    Price = p.Price,
                    Stock = p.Stock,
                    ViewCount = p.ViewCount,
                    DateCreated = p.DateCreated,
                    Name = p.Name,
                    Description = p.Description,
                    Details = p.Details,
                    sold = p.sold,
                    productStatus = p.productStatus
                }).ToList()
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetById( int id)
        {
            var query = from c in _context.Categories where c.Id==id
                        select  c;
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                IsShowOnHome = x.IsShowOnHome,
                Status = x.Status,
                SortOrder = x.SortOrder
            }).FirstOrDefaultAsync();
        }

        public async Task<RequestResult<bool>> UpdateCategory(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);


            if (category == null) throw new ProjectException($"Cannot find a product with id: {request.Id}");

            category.Name = request.Name;
            category.Description = request.Description;
            category.IsShowOnHome = request.IsShowOnHome;
            category.Status = request.Status;
            string error=null;
            int result = 0;
            try
            {
                 result = await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                error = e.Message;
            }
            
            
            return (result==1)? new RequestSuccessResult<bool>(): new RequestErrorResult<bool>(error) ;
        }
    }
}