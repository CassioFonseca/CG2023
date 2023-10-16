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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DbSetSubCategoria>().HasOne(sc => sc.Categoria).WithMany(c => c.SubCategorias).HasForeignKey(sc => sc.CategoriaId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.Categoria).WithMany(c => c.Lancamentos).HasForeignKey(l => l.CategoriaId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.Favorecido).WithMany(f => f.Lancamentos).HasForeignKey(l => l.FavorecidoId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.Fornecedor).WithMany(f => f.Lancamentos).HasForeignKey(l => l.FornecedorId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.Instituicao).WithMany(i => i.Lancamentos).HasForeignKey(l => l.InstituicaoId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.Modalidade).WithMany(m => m.Lancamentos).HasForeignKey(l => l.ModalidadeId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.Pagador).WithMany(p => p.Lancamentos).HasForeignKey(l => l.PagadorId);
            modelBuilder.Entity<DbSetLancamento>().HasOne(l => l.SubCategoria).WithMany(s => s.Lancamentos).HasForeignKey(l => l.SubCategoriaId);

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
