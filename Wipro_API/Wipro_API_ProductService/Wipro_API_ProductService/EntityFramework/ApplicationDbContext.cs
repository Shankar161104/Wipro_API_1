using Microsoft.EntityFrameworkCore;
using Wipro_API_ProductService.Model;



namespace Wipro_API_ProductService.EntityFramework
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
