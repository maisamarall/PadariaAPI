using PadariaAPI.Models;
using PadariaAPI.Interfaces;
using PadariaAPI.Service;
using System.Linq;

namespace PadariaAPI.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        
        public void CreateClient(Client newClient)
        {
            var clientBuscado = _clientRepository.GetClients().FirstOrDefault(c => c.Name == newClient.Name);
            
            if (clientBuscado != null)
            {
                throw new Exception("Cliente já cadastrado");
            }

            _clientRepository.CreateClient(newClient);
        }
        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }
        public Client ObterClientePorId(int id)
        {
            return _clientRepository.GetClients().FirstOrDefault(c => c.Id == id);
        }
        public void AtualizarCliente(Client clienteAtualizado)
        {
            _clientRepository.AtualizarCliente(clienteAtualizado);
        }
    }
}
