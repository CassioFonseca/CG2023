using CGEntity.EntitiesDbSet;

namespace CGServer.Repository
{
    public class SubCategoriaRepository : BaseRepository<DbSetSubCategoria>
    {
        public DbSetSubCategoria GetFirstCategoria(int idCategoria)
        {
            DbSetSubCategoria result = DbSetRepository.First(p => p.CategoriaId == idCategoria);
            return result;
        }
    }
}
