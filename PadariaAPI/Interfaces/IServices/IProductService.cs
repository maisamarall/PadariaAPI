using PadariaAPI.Models;

namespace PadariaAPI.Interfaces.IServices
{
    public interface IProductService
    {
        public Product CreateProduct(Product product);
        public List<Product> GetProducts();
        public Product ProcurarPorId(Guid Id);
        public void AtualizarEstoque(Guid Id, int Quantity);
    }
}
