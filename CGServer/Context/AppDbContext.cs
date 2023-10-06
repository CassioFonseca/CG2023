using CGEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CGServer.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Favorecido> Favorecidos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }

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
            string diretorio = "D:\\Desenvolvimento\\CFSoftOne\\CG2023\\CGServer";
            var builder = new ConfigurationBuilder().SetBasePath(diretorio).AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }

    }
}
