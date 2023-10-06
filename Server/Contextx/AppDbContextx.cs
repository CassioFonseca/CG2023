using CGEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Server.Context
{
    public class AppDbContextx : DbContext
    {

        string conectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public AppDbContextx(DbContextOptions<AppDbContextx> options) : base(options)
        { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Favorecido> Favorecidos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(conectionstring);
            }
        }

    }
}
