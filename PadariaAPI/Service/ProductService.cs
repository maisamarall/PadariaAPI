using PadariaAPI.Models;
using PadariaAPI.Interfaces;

namespace PadariaAPI.Service
{
    public class ProductService : IProductService
    {
        private object _productRepository;

        public void CreateProduct(Product newProduct)
        {
            var produtoBuscado = _productRepository.GetProducts().FirstOrDefault(p => p.Name == newProduct.Name);
            
            if(produtoBuscado != null)
            {
                throw new Exception("Produto já cadastrado");
            }

            object value = _productRepository.CreateProduct(newProduct);
        }
        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
