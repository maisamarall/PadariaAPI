using PadariaAPI.Models;

namespace PadariaAPI.Interfaces
{
    public interface IVendaService
    {
        Venda CriarVenda(Venda novaVenda);
        // Aqui poderiamos adicionar outros métodos como ObterVendaPorId, por exemplo.
    }
}