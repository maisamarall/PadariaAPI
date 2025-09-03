using PadariaAPI.Models;

namespace PadariaAPI.Interfaces.IRepositories
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public Product CreateProduct(Product product);
        public Product ProcurarPorId(Guid Id);
    }
}
