using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class InstituicaoRepository
    {
        private DbSetInstituicao DbSetInstituicao { get; set; }
        private DbContext DbContext { get; set; }
        public InstituicaoRepository(Instituicao instituicao)
        {
            this.DbSetInstituicao = instituicao.dbSetInstituicao;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarFavorecido()
        {
            var favorecido = DbContext.Set<DbSetInstituicao>();
            this.DbSetInstituicao.Id = 0;
            favorecido.Add(this.DbSetInstituicao);
            SalvarCategoria();
            return this.DbSetInstituicao.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
