using Microsoft.AspNetCore.Mvc;
using PadariaAPI.Interfaces;
using PadariaAPI.Models;
using PadariaAPI.Service;

namespace PadariaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet(Name = "GetClients")]
        public IActionResult GetClients()
        {
            List<Client> clients = _clientService.GetClients();
            return Ok(clients);
        }

        [HttpGet(Name = "GetClientById")]
        public IActionResult ObterClientePorId(int id)
        {
            Client client = _clientService.ObterClientePorId(id);
            return Ok(client);
        }

        [HttpPost(Name = "CreateClient")]
        public IActionResult CreateClient(Client newClient)
        {
            _clientService.CreateClient(newClient);
            return Ok();
        }

    }
}
