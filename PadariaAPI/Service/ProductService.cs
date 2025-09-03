using PadariaAPI.Models;
using PadariaAPI.Interfaces.IServices;
using PadariaAPI.Interfaces.IRepositories;

namespace PadariaAPI.Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product CreateProduct(Product product)
        {
            Product newProduct = _productRepository.CreateProduct(product);

            return newProduct;
        }
        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
        public Product ProcurarPorId(Guid Id)
        {
            try
            {
                return _productRepository.ProcurarPorId(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarEstoque(Guid ProductId, int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}

