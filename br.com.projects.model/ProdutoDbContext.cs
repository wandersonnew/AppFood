using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodV2.br.com.projects.model
{
    public class ProdutoDbContext : DbContext
    {
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
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos");
                entity.Property(e => e.IdProduto).IsRequired();
                entity.Property(e => e.Nome).IsRequired();
                entity.Property(e => e.Preco).IsRequired();
                entity.Property(e => e.Descricao).IsRequired(false);
            });
        }
    }
}
