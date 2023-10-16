using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class SubCategoriaUC
    {
        public SubCategoriaUC() { }
        public int Adicionar(int idCategoria,string descSubCategoria)
        {
            SubCategoria subCategoria = Criar(idCategoria, descSubCategoria);
            SubCategoriaRepository subCategoriaRepository = new SubCategoriaRepository();
            subCategoriaRepository.AdicionarDbSet(subCategoria.DbSetSubCategoria);
            Salvar(subCategoriaRepository);
            return subCategoria.Id;
        }
        public SubCategoria Criar(int idCategoria, string descSubCategoria)
        {
            return new SubCategoria(idCategoria, descSubCategoria);
        }
        public SubCategoria Criar(DbSetSubCategoria dbSetSubCategoria)
        {
            return new SubCategoria(dbSetSubCategoria);
        }
        private void Salvar(SubCategoriaRepository pagadorRepository)
        {
            pagadorRepository.Salvar();
        }
        public SubCategoria? GetId(int id)
        {
            SubCategoriaRepository subCategoriaRepository = new SubCategoriaRepository();
            DbSetSubCategoria? dbSetSubCategoria = subCategoriaRepository.DbSetGetId(id);
            if (dbSetSubCategoria == null) return null;
            SubCategoria subCategoria = Criar(dbSetSubCategoria);
            return subCategoria;
        }
        public SubCategoria? GetFirst()
        {
            SubCategoriaRepository subCategoriaRepository = new SubCategoriaRepository();
            DbSetSubCategoria? dbSetSubCategoria = subCategoriaRepository.DbSetGetFirst();
            if (dbSetSubCategoria == null) return null;
            SubCategoria subCategoria = Criar(dbSetSubCategoria);
            return subCategoria;
        }
        public SubCategoria? GetFirst(int idCategoriaId)
        {
            SubCategoriaRepository subCategoriaRepository = new SubCategoriaRepository();
            DbSetSubCategoria? dbSetSubCategoria = subCategoriaRepository.DbSetGetFirst(idCategoriaId);
            if (dbSetSubCategoria == null) return null;
            SubCategoria subCategoria = Criar(dbSetSubCategoria);
            return subCategoria;
        }
    }
}

