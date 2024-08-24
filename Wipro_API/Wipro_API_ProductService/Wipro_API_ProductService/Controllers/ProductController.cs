using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_ProductService.Repository;
using Wipro_API_ProductService.Model;
using Wipro_API_ProductService.EntityFramework;




namespace Wipro_API_ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService iproductservice;

        public ProductController(IProductService _iproductservice)
        {
            iproductservice = _iproductservice;
        }

        [HttpPost("Create")]

        public ActionResult CreateProduct(Product product)
        {
            return Ok(iproductservice.CreateProduct(product));
        }


        [HttpPost("ProductList")]


        public ActionResult GetProductList()
        {
            return Ok(iproductservice.GetProducts());
        }

        [HttpPost("SearchProductByID")]

        public ActionResult SearchProduct(int ProductID)
        {
            return Ok(iproductservice.SearchProduct(ProductID));
            
        }

        [HttpPost("UpdateProduct")]

        public ActionResult UpdateProduct(Product product)
        {
            return Ok(iproductservice.UpdateProduct(product));
        }

        [HttpPost("DeleteProduct")]

        public ActionResult DeleteProduct(Product product)
        {
            return Ok(iproductservice.DeleteProduct(product));
        }
    }
}
