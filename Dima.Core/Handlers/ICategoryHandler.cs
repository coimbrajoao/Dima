using Dima.Core.Models;
using Dima.Core.Requests.Categories;
using Dima.Core.Responses;

namespace Dima.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category>> DeleteAsync(CategoryDeleteRequest request);
        Task<Response<Category>> UpdateAsync(CategoryUpdateRequest request);
        Task<Response<List<Category>>> GetallAsync(GetAllCategoryRequest request);
        Task<Response<Category>> GetByIdAsync(GetCategoryByIdRequest request);

    }
}