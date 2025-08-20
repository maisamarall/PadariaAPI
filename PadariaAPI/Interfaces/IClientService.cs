using PadariaAPI.Models;

namespace PadariaAPI.Interfaces
{
    public interface IClientService
    {
        public Client ObterClientePorId(int id);

        public List<Client> GetClients();
    }
}
