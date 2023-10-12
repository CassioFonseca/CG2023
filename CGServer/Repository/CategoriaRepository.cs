using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class CategoriaRepository
    {
        private DbSetCategoria DbSetCategoria { get; set; }
        private DbContext DbContext { get; set; }
        public CategoriaRepository(Categoria categoria) 
        { 
            this.DbSetCategoria = categoria.DbSetCategoria;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarCategoria()
        {
            var categoria = DbContext.Set<DbSetCategoria>();
            this.DbSetCategoria.Id = 0;
            categoria.Add(this.DbSetCategoria);
            SalvarCategoria();
            return this.DbSetCategoria.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
