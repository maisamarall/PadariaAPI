using Microsoft.AspNetCore.Mvc;
using PadariaAPI.Interfaces.IServices;
using PadariaAPI.Models;

namespace PadariaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _vendaService;

        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [HttpPost(Name = "CreateVenda")]
        public IActionResult CriarVenda([FromBody] Venda vendaDto)
        {
            try
            {
                _vendaService.Create(vendaDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}