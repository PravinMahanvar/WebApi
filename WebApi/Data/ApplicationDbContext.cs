using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebAPIProject.Models;

namespace WebApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
      
        public DbSet<Category> Categories { get; set; }
    }
}
