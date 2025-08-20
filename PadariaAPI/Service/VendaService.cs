using PadariaAPI.Controllers;
using PadariaAPI.Interfaces;
using PadariaAPI.Models;

namespace PadariaAPI.Service
{
    public class VendaService : IVendaService
    {
        private readonly IClientService _clientService;
        private readonly IProductService _productService;
        // contexto do banco de dados para salvar a venda

        public VendaService(IClientService clientService, IProductService productService )
        {
            _clientService = clientService;
            _productService = productService;
        } /*, RepositorioDeVendas */

        public Venda CriarVenda(Venda venda)
        {
            // Valida se o cliente existe
            var clienteExiste = _clientService.ObterClientePorId(venda.Cliente.Id);
            if (clienteExiste == null)
            {
                throw new Exception("Cliente não encontrado.");
            }

            // Valida se o produto existe e o estoque
            foreach (var item in venda.Itens)
            {
                var produto = _productService.ObterProdutoPorId(item.Produto.Id);
                if (produto == null)
                {
                    throw new Exception($"Produto com ID {item.Produto.Id} não encontrado.");
                }
                if (item.Quantidade > produto.Estoque)
                {
                    throw new Exception($"Estoque insuficiente para o produto {produto.Nome}.");
                }
            }
            return venda;
        }
    }
}