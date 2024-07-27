using Dima.Api.Data;
using Dima.Core.Handlers;
using Dima.Core.Models;
using Dima.Core.Requests.Categories;
using Dima.Core.Responses;

namespace Dima.Api.Handlers
{
    public class CategoryHandler(AppDbContext context) : ICategoryHandler
    {
        public async Task<Response<Category>> CreateAsync(CreateCategoryRequest request)
        {
            try
            {

                var category = new Category
                {
                    Title = request.Title,
                    Description = request.Description,
                    UserId = request.UserId
                };

                await context.AddAsync(category);
                await context.SaveChangesAsync();

                return new Response<Category>(category);
            }
            catch (Exception ex)
            {

                System.Console.WriteLine(ex);
                throw new Exception("Falha ao criar categoria");
            }

        }

        public Task<Response<Category>> DeleteAsync(CategoryDeleteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Category>>> GetallAsync(GetAllCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Category>> GetByIdAsync(GetCategoryByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Category>> UpdateAsync(CategoryUpdateRequest request)
        {
            throw new NotImplementedException();
        }

    }
}