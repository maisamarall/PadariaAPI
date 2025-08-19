using PadariaAPI.Models;

using System.Runtime.InteropServices;

namespace PadariaAPI.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetProducts();

        public void CreateProduct(Product newProduct);
    }
}
