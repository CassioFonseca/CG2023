using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class ModalidadeRepository
    {
        private DbSetModalidade DbSetModalidade { get; set; }
        private DbContext DbContext { get; set; }
        public ModalidadeRepository(Modalidade modalidade)
        {
            this.DbSetModalidade = modalidade.DbSetModalidade;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarFavorecido()
        {
            var modalidade = DbContext.Set<DbSetModalidade>();
            this.DbSetModalidade.Id = 0;
            modalidade.Add(this.DbSetModalidade);
            SalvarCategoria();
            return this.DbSetModalidade.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
