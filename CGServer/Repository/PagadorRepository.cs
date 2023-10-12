using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class PagadorRepository
    {
        private DbSetPagador DbSetPagador { get; set; }
        private DbContext DbContext { get; set; }
        public PagadorRepository(Pagador pagador)
        {
            this.DbSetPagador = pagador.DbSetPagador;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarFavorecido()
        {
            var pagador = DbContext.Set<DbSetPagador>();
            this.DbSetPagador.Id = 0;
            pagador.Add(this.DbSetPagador);
            SalvarCategoria();
            return this.DbSetPagador.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
