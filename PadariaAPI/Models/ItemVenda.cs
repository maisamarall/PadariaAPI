using System.Collections.Generic;

namespace PadariaAPI.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public System.DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }

        public List<ItemVenda> Itens { get; set; }
    }
}