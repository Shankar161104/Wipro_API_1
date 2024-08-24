using Wipro_API_ProductService.Model;
using Wipro_API_ProductService.EntityFramework;


namespace Wipro_API_ProductService.Repository
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product SearchProduct(int id);

        int UpdateProduct(Product product);
        int CreateProduct(Product product);

        int DeleteProduct(Product product);
    }
}
