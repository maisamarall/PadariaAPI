﻿namespace PadariaAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Preco { get; set; }
        public int Quantity { get; set; }
        public virtual List<Venda> Vendas { get; set; }
    }
}
