using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodV2.br.com.projects.model
{
    public class PedidoDbContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //object conn = optionsBuilder.UseSqlServer(
            //    @"Server=(local)\mssqllocaldb;Database=AppFood;"
            //    + "Trusted_Connection=True;"
            //);

            optionsBuilder.UseMySQL("server=localhost;database=appfood;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("pedidos");
                entity.Property(e => e.IdPedido).IsRequired();
                entity.Property(e => e.IdProduto).IsRequired();
                entity.Property(e => e.IdCliente).IsRequired();
                entity.Property(e => e.Endereco).IsRequired(false);
                entity.Property(e => e.Bairro).IsRequired(false);
                entity.Property(e => e.Complemento).IsRequired(false);
                entity.Property(e => e.Numero).IsRequired(false);
                entity.Property(e => e.Quantidade).IsRequired();
                entity.Property(e => e.Preco).IsRequired();
                entity.Property(e => e.Observacao).IsRequired(false);
            });
        }
    }
}
