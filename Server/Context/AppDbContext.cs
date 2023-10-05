using CGEntity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Favorecido> Favorecidos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }

    }
}
