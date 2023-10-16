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
        protected readonly DbSet<T> DbSetRepository;
        public BaseRepository()
        {
            this.DbContext = new AppDbContext();
            this.DbSetRepository = this.DbContext.Set<T>();
        }

        public void AdicionarDbSet(T entidade)
        {
            this.DbSetRepository.Add(entidade);
        }
        public void Salvar()
        {
            this.DbContext.SaveChanges();
        }
        public T? DbSetGetId(int id)
        {
            return DbSetRepository.Find(id);
        }
        public T? DbSetGetFirst()
        {
            T? result = DbSetRepository.First();
            return result;
        }
    }
}
