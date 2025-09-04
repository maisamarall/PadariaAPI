namespace PadariaAPI.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual List<Venda> Vendas { get; set; }
    }
}
