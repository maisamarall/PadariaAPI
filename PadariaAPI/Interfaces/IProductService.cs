using PadariaAPI.Models;
using System.Runtime.InteropServices;

namespace PadariaAPI.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        void CreateProduct(Product newProduct);
        Product ObterProdutoPorId(int id);
        void AtualizarProduto(Product produto); // Adicionando o método AtualizarProduto  
    }
    public interface IProductRepository
    {
        void CreateProduct(Product newProduct);
        List<Product> GetProducts();
        void AtualizarProduto(Product produtoAtualizado);
    }
}
