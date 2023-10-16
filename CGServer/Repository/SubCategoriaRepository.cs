using CGEntity.EntitiesDbSet;

namespace CGServer.Repository
{
    public class SubCategoriaRepository : BaseRepository<DbSetSubCategoria>
    {
        public DbSetSubCategoria DbSetGetFirst(int idCategoria)
        {
            DbSetSubCategoria result = DbSetRepository.First(p => p.CategoriaId == idCategoria);
            return result;
        }
    }
}
