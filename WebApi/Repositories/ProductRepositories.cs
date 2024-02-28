using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebAPIProject.Models;

namespace WebApi.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly ApplicationDbContext db;
        public ProductRepositories(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<int> AddProduct(Product product)
        {
            int result = 0;
            await db.Products.AddAsync(product);
            result = await db.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteProduct(int id)
        {
            int result = 0;
            var product = await db.Products.Where(x => x.P_id == id).FirstOrDefaultAsync();
            if (product != null)
            {
                db.Products.Remove(product);
                result = await db.SaveChangesAsync();
            }
            return result;
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await db.Products.Where(x => x.P_id == id).FirstOrDefaultAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await db.Products.ToListAsync();
        }


        public async Task<int> UpdateProduct(Product product)
        {
            int result = 0;
            var p = await db.Products.Where(x => x.P_id == product.P_id).FirstOrDefaultAsync();
            if (p != null)
            {
                p.P_name = product.P_name;
                p.Price = product.Price;
                p.Image = product.Image;
                result = await db.SaveChangesAsync();
            }
            return result;
        }
    }
}
