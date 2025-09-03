using Microsoft.AspNetCore.Mvc;
using PadariaAPI.Interfaces.IServices;
using PadariaAPI.Models;

namespace PadariaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientService _clientService;

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

        [HttpPost(Name = "CreateClient")]
        public IActionResult PostClient(Client client)
        {
            _clientService.CreateClient(client);
            return Ok();
        }

    }
}
