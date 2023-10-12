using CGEntity.EntitiesDbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CGServer.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<DbSetCategoria> Categorias { get; set; }
        public DbSet<DbSetFavorecido> Favorecidos { get; set; }
        public DbSet<DbSetFornecedor> Fornecedores { get; set; }
        public DbSet<DbSetInstituicao> Instituicoes { get; set; }
        public DbSet<DbSetLancamento> Lancamentos { get; set; }
        public DbSet<DbSetModalidade> Modalidades { get; set; }
        public DbSet<DbSetPagador> Pagadores { get; set; }
        public DbSet<DbSetSubCategoria> SubCategorias { get; set; }
        public DbSet<DbSetTesteX> TesteX { get; set; }
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
