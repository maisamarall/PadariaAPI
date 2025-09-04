using Microsoft.EntityFrameworkCore;
using PadariaAPI.Models;

namespace PadariaAPI.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(client => client.Id);

            modelBuilder.Entity<Product>()
                .HasKey(product => product.Id);

            modelBuilder.Entity<Venda>()
                .HasKey(venda => venda.Id);

            modelBuilder.Entity<Venda>()
                .HasOne(venda => venda.Client)
                .WithMany(client => client.Vendas)
                .HasForeignKey(venda => venda.ClientId);

            modelBuilder.Entity<Venda>()
                .HasOne(venda => venda.Product)
                .WithMany(product => product.Vendas)
                .HasForeignKey(venda => venda.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}



