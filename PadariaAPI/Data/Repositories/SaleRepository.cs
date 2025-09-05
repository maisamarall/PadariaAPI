using PadariaAPI.Data.Context;
using PadariaAPI.Interfaces.IRepositories;
using PadariaAPI.Models;

namespace PadariaAPI.Data.Repositories
{
    public class SaleRepository : IVendaRepository
    {
        private readonly DataContext _db;

        public SaleRepository(DataContext db)
        {
            _db = db;
        }

        public void CreateVenda(Venda venda)
        {
            _db.Vendas.Add(venda);
        }

        public Venda ProcurarPorId(Guid id)
        {
            return _db.Vendas
                .Select(venda => venda)
                .Where(venda => venda.Id == id)
                .First();
        }

        public List<Venda> GetVendas()
        {
            List<Venda> result = _db.Vendas
                .Select(venda => venda)
                .ToList();

            return result;
        }
    }
}
