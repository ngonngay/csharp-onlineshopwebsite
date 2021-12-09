
using Project.ViewModels.Categories;
using Project.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<CategoryViewModel> GetById(int id);
        Task<RequestResult<bool>> UpdateCategory(CategoryUpdateRequest request);
        Task<RequestResult<bool>> Create(CategoryCreateRequest request);
       
    }
}