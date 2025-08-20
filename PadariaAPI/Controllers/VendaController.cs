using Microsoft.AspNetCore.Mvc;
using PadariaAPI.Interfaces;
using PadariaAPI.Models;
using PadariaAPI.Service;

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

        [HttpGet]
        public IActionResult GetVendas()
        {
            var vendas = _vendaService.GetVendas();
            return Ok(vendas);
        }

        [HttpPost]
        public IActionResult CriarVenda(Venda venda)
        {
            try
            {
                var vendaCriada = _vendaService.CriarVenda(venda);
                return Ok(vendaCriada); // Aqui vai retornar a venda foi criada com sucesso
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna um erro em caso de falha nas valid.
            }
        }
    }
}