using Wipro_API_ProductService.Model;
using Wipro_API_ProductService.EntityFramework;

namespace Wipro_API_ProductService.Repository
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public int CreateProduct(Product product)
        {
            applicationDbContext.Add(product);
            return applicationDbContext.SaveChanges();
        }

        public int DeleteProduct(Product product)
        {
            if (applicationDbContext == null)
            {
                throw new ArgumentException("Entity Missing");
            }
            applicationDbContext.Products.Remove(product);
            return applicationDbContext.SaveChanges();
        }


        public Product SearchProduct(int id)
        {
            return applicationDbContext.Products.SingleOrDefault(t => t.ProductID == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return applicationDbContext.Products.ToList();
        }

        

        public int UpdateProduct(Product product)
        {
            if (applicationDbContext == null)
            {
                throw new ArgumentException("Entity Missing");
            }
            applicationDbContext.Products.Update(product);
            return applicationDbContext.SaveChanges();
        }
    }
}
