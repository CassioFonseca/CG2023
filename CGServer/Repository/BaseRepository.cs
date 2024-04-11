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

        public void Add(T entidade)
        {
            this.DbSetRepository.Add(entidade);
        }
        public void Salve()
        {
            this.DbContext.SaveChanges();
        }
        public T? GetId(int id)
        {
            return DbSetRepository.Find(id);
        }
        public T? GetFirst()
        {
            T? result = DbSetRepository.First();
            return result;
        }
        public List<T> GetAll()
        {
            return DbSetRepository.ToList();
        }
        public void Update(T entity)
        {
            this.DbSetRepository.Update(entity);
            this.Salve();
        }
        public void Remove(T entity)
        {
            this.DbSetRepository.Remove(entity);
            this.Salve();
        }


    }
}
