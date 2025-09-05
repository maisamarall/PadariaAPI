using PadariaAPI.Models;

namespace PadariaAPI.Interfaces.IRepositories
{
    public interface IVendaRepository
    {
        public List<Venda> GetVendas();
        public void CreateVenda(Venda venda);
        public Venda ProcurarPorId(Guid id);
        
    }
}
