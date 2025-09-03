using Microsoft.AspNetCore.Mvc;
using PadariaAPI.Interfaces.IServices;
using PadariaAPI.Models;

namespace PadariaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetProducts")]
        public IActionResult GetProducts()
        {
            List<Product> products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }
    }
}
