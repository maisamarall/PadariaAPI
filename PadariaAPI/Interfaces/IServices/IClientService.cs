using PadariaAPI.Models;

namespace PadariaAPI.Interfaces.IServices
{
    public interface IClientService
    {
        void CreateClient(Client newClient);
        List<Client> GetClients();
    }
}
