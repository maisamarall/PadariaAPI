using PadariaAPI.Data.Context;
using PadariaAPI.Models;
using PadariaAPI.Interfaces.IRepositories;

namespace PadariaAPI.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _db;

        public ProductRepository(DataContext db)
        {
            _db = db;
        }

        public void CreateProduct(Product product)
        {
            _db.Products.Add(product);
        }

        public  Product ProcurarPorID(Guid Id)
        {
            return _db.Products.Select(p => p)
                .Where(p => p.Id == Id)
                .First();
        }

        public List<Product> GetProducts()
        {
            List<Product> result = _db.Products
                .Select(product => product)
                .ToList();

            return result;
        }

        public Product ProcurarPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
