using System;
using System.Collections.Generic;

namespace PadariaAPI.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public Client Cliente { get; set; } 
        public List<ItemVenda> Itens { get; set; } // Aqui seria uma lista de itens da venda
    }

    public class ItemVenda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Product Product { get; set; } // Referência à classe Product
    }
}