using PadariaAPI.Models;
using PadariaAPI.Interfaces.IServices;
using PadariaAPI.Interfaces.IRepositories;

namespace PadariaAPI.Service
{
    public class ClientService : IClientService
    {
        private IClientRepository _clientRepository;

        public ClientService() { }

        public void CreateClient(Client client)
        {
            var clientWithEmail = _clientRepository.PegarClientePorEmail(client.Email);

            if (clientWithEmail != null)
            {
                throw new Exception("Email ja cadastrado.");
            }

            _clientRepository.CreateClient(client);
        }
        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }
    }
}
