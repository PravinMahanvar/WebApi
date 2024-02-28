using WebApi.Models;

namespace WebApi.Services
{
    public interface ICategoryServices
    {
        Task<IEnumerable<Category>> GetCategorys();
        Task<Category> GetCategorytById(int id);
        Task<int> AddCategory(Category category);
        Task<int> UpdateCategory(Category category);
        Task<int> DeleteCategory(int id);

    }
}