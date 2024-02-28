using WebApi.Repositories;
using WebAPIProject.Models;

namespace WebApi.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositories repo;
        public ProductServices(IProductRepositories repo)
        {
            this.repo = repo;
        }

        public async Task<int> AddProduct(Product product)
        {
            return await repo.AddProduct(product);
        }

        public async Task<int> DeleteProduct(int id)
        {
            return await repo.DeleteProduct(id);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await repo.GetProductById(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await repo.GetProducts();
        }

        public async Task<int> UpdateProduct(Product product)
        {
            return await repo.UpdateProduct(product);
        }
    }
}

