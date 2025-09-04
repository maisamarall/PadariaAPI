using System;
using System.Collections.Generic;

namespace PadariaAPI.Models
{
    public class Venda
    {
        public Guid Id { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}