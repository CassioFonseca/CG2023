using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGServer.Repository
{
    public class BaseRepository<T> where T : class
    {
        private readonly DbContext DbContext;
        private readonly DbSet<T> DbSetRepository;
        public BaseRepository()
        {
            this.DbContext = new AppDbContext();
            this.DbSetRepository = this.DbContext.Set<T>();
        }

        public void Adicionar(T entidade)
        {
            this.DbSetRepository.Add(entidade);
        }
        public void Salvar()
        {
            this.DbContext.SaveChanges();
        }
        public T GetId(int id)
        {
            return DbSetRepository.Find(id);
        }
    }
}
