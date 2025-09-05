using PadariaAPI.Interfaces.IRepositories;
using PadariaAPI.Interfaces.IServices;
using PadariaAPI.Models;

namespace PadariaAPI.Service
{
    public class VendaService : IVendaService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IProductService _productService;
        private readonly IVendaRepository _vendaRepository;
        // contexto do banco de dados para salvar a venda

        public VendaService(IClientRepository clientRepository, IProductService productService, IVendaRepository vendaRepository)
        {
            _clientRepository = clientRepository;
            _productService = productService;
            _vendaRepository = vendaRepository;
        } /*, RepositorioDeVendas */

        public void CreateVenda(Venda vendaDto)
        {
            try
            {
                Client clientOld = _clientRepository.ProcurarPorId(vendaDto.ClientId);
                if (clientOld == null)
                {
                    throw new Exception("Cliente invalido");
                }

                Product productOld = _productService.ProcurarPorId(vendaDto.ClientId);
                if (clientOld == null)
                {
                    throw new Exception("Cliente invalido");
                }

                if (productOld.Quantity < vendaDto.Quantity)
                {
                    throw new Exception("Estoque indisponivel");
                }

                _productService.AtualizarEstoque(productOld.Id, vendaDto.Quantity);

                Venda newVenda = new Venda();

                newVenda.Quantity = vendaDto.Quantity;
                newVenda.Price = vendaDto.Price;
                newVenda.ClientId = vendaDto.ClientId;
                newVenda.ProductId = vendaDto.ProductId;

                _vendaRepository.CreateVenda(newVenda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}