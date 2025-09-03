using PadariaAPI.Models;

namespace PadariaAPI.Interfaces.IRepositories
{
    public interface IClientRepository
    {
        public List<Client> GetClients();
        public Client PegarClientePorEmail(string email);
        public Client ProcurarPorId(Guid Id);
        public void CreateClient(Client client);
    }
}
