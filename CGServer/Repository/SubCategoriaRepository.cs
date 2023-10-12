using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class SubCategoriaRepository
    {
        private DbSetSubCategoria DbSetSubCategoria { get; set; }
        private DbContext DbContext { get; set; }
        public SubCategoriaRepository(SubCategoria subCategoria)
        {
            this.DbSetSubCategoria = subCategoria.DbSetSubCategoria;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarFavorecido()
        {
            var subCategoria = DbContext.Set<DbSetSubCategoria>();
            this.DbSetSubCategoria.Id = 0;
            subCategoria.Add(this.DbSetSubCategoria);
            SalvarCategoria();
            return this.DbSetSubCategoria.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
