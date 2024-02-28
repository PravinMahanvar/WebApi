using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IcategoryRepositories repo;
        public CategoryServices(IcategoryRepositories repo)
        {
            this.repo = repo;
        }

        public  async Task<int> AddCategory(Category category)
        {
            return await repo.AddCategory(category);
        }

        public async Task<int> DeleteCategory(int id)
        {
            return await repo.DeleteCategory(id);
        }

        public async  Task<IEnumerable<Category>> GetCategorys()
        {
            return await repo.GetCategorys();
        }

        public async Task<Category> GetCategorytById(int id)
        {
            return await repo.GetCategorytById(id);
        }

        public async Task<int> UpdateCategory(Category category)
        {
           return await repo.UpdateCategory(category);
        }
    }
}
