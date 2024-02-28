using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class CategoryRepositories : IcategoryRepositories

    {
        private readonly ApplicationDbContext db;
        public CategoryRepositories(ApplicationDbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }

        public async Task<int> AddCategory(Category category)
        {
            int result = 0;
            await db.Categories.AddAsync(category);
            result = await db.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteCategory(int id)
        {
            int result = 0;
            var category = await db.Categories.Where(x => x.c_id == id).FirstOrDefaultAsync();
            if (category != null)
            {
                db.Categories.Remove(category);
                result = await db.SaveChangesAsync();
            }
            return result;
        }

        public async  Task<IEnumerable<Category>> GetCategorys()
        {
            return await db.Categories.ToListAsync();
        }

        public async Task<Category> GetCategorytById(int id)
        {
            var category = await db.Categories.Where(x => x.c_id == id).FirstOrDefaultAsync();
            return category;
        }

        public async Task<int> UpdateCategory(Category category)
        {
            int result = 0;
            var c = await db.Categories.Where(x => x.c_id == category.c_id).FirstOrDefaultAsync();
            if (c != null)
            {
                c.c_name = c.c_name;

                result = await db.SaveChangesAsync();
            }
            return result;
        }
    }
}
