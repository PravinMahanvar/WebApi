using WebApi.Models;

namespace WebApi.Repositories
{
    public interface IcategoryRepositories
    {
        Task<IEnumerable<Category>> GetCategorys();
        Task<Category> GetCategorytById(int id);
        Task<int> AddCategory(Category category);
        Task<int> UpdateCategory(Category category);
        Task<int> DeleteCategory(int id);
    }
}
