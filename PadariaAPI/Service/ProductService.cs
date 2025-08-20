using PadariaAPI.Models;
using PadariaAPI.Interfaces;
using PadariaAPI.Service;
using System.Linq;

namespace PadariaAPI.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(Product newProduct)
        {
            var produtoBuscado = _productRepository.GetProducts().FirstOrDefault(p => p.Name == newProduct.Name);
            
            if(produtoBuscado != null)
            {
                throw new Exception("Produto já cadastrado");
            }

            _productRepository.CreateProduct(newProduct);
        }
        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
        public Product ObterProdutoPorId(int id)
        {
            return _productRepository.GetProducts().FirstOrDefault(p => p.Id == id);
        }

        public void AtualizarProduto(Product produtoAtualizado)
        {
            _productRepository.AtualizarProduto(produtoAtualizado);
        }
    }
}

