using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CGServer.Context
{
    public class AppDbContext : DbContext
    {
  
        //public DbSet<Banco> Bancos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConection());
            }

        }

        private string? GetStringConection()
        {
            string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Diretório Local da Aplicação: " + diretorioAtual);

            string diretorio = "D:\\Desenvolvimento\\CFSoftOne\\CG2023\\CGServer";
            var builder = new ConfigurationBuilder().SetBasePath(diretorio).AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }

    }
}
