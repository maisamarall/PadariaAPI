using Microsoft.AspNetCore.Mvc;
using PadariaAPI.Interfaces;
using PadariaAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace PadariaAPI.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class ProductController : Controller
    {
        private IProductService _productService;

        [HttpGet(Name = "GetProducts")]

        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProduct (Product newProduct)
        {
            _productService.CreateProduct(newProduct);
            return Ok();
        }
    }
}
