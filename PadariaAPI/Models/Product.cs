namespace PadariaAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Preço { get; set; }
        public int Estoque { get; set; } // ou podemos adicionar 'string' e ficar como "Disponível" ou "Indisponível"
    }
}
