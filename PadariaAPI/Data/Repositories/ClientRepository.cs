using PadariaAPI.Data.Context;
using PadariaAPI.Models;
using PadariaAPI.Interfaces.IRepositories;

namespace PadariaAPI.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _db;

        public ClientRepository(DataContext db)
        {
            _db = db;
        }

        public void CreateClient(Client client)
        {
            _db.Clients.Add(client);
        }

        public Client PegarClientePorEmail(string email)
        {
            return _db.Clients
                .Select(client => client)
                .Where(Client => Client.Email.Equals(email))
                .First();
        }

        public Client ProcurarPorId(Guid Id)
        {
            return _db.Clients.Select(c => c)
                .Where(c => c.Id == Id)
                .First();
        }

        public List<Client> GetClients()
        {
            List<Client> result = _db.Clients
                .Select(client => client)
                .ToList();

            return result;
        }

    }
}
