using PadariaAPI.Models;
using System.Runtime.InteropServices;

namespace PadariaAPI.Interfaces
{
    public interface IClientService
    {
        List<Client> GetClients();
        void CreateClient(Client newClient);
        Client ObterClientePorId(int id);
        void AtualizarCliente(Client clienteAtualizado);
    }

    public interface IClientRepository
    {
        void CreateClient(Client newClient);
        List<Client> GetClients();
        void AtualizarCliente(Client clienteAtualizado);
    }
}
