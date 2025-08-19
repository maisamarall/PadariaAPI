using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PadariaAPI.Models;

namespace PadariaAPI.Controllers
{
    public class ClientController : ControllerBase
    {
        private IClientService _clienteService;
        private IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet(Name = "GetClientes")]

        public IActionResult GetClientes()
        {
            List<Client> clients = _clientService.GetClients();
            return Ok(clients);
        }

        [HttpPost(Name = "GetClientById")]

        public IActionResult GetCliente(int id)
        {
            Client cliente = _clienteService.GetClienteById(id);
            return Ok(cliente);
        }
    }

    public interface IClientService
    {
    }
}
