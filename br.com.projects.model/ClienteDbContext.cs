using Microsoft.EntityFrameworkCore;

namespace AppFoodV2.br.com.projects.model
{
    public class ClienteDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClienteDbContext).Assembly);
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");
                entity.Property(e => e.IdCliente).IsRequired();
                entity.Property(e => e.Nome).IsRequired();
                entity.Property(e => e.CPF).IsRequired();
                entity.Property(e => e.Celular).IsRequired();
                entity.Property(e => e.Endereco).IsRequired();
                entity.Property(e => e.Bairro).IsRequired();
                entity.Property(e => e.Numero).IsRequired();
                entity.Property(e => e.RG).IsRequired(false);
                entity.Property(e => e.Email).IsRequired(false);
                entity.Property(e => e.Complemento).IsRequired(false);
                entity.Property(e => e.CEP).IsRequired(false);
                entity.Property(e => e.Cidade).IsRequired(false);
            });
        }
    }
}
