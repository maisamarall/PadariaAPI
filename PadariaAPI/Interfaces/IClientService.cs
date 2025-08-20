using PadariaAPI.Models;

namespace PadariaAPI.Interfaces
{
    public interface IClientService
    {
        public Client ObterClientePorId(int id);
    }
}
