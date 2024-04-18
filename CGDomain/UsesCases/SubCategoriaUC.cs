using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class SubCategoriaUC
    {
        public SubCategoriaUC() { }
        private static SubCategoriaRepository Repository
        {
            get { return new(); }
        }
        public static int Add(int idCategoria, string dsSubCategoria)
        {
            if (string.IsNullOrWhiteSpace(dsSubCategoria))
            {
                throw new ArgumentException($"'{nameof(dsSubCategoria)}' cannot be null or whitespace.", nameof(dsSubCategoria));
            }
            SubCategoria subCategoria = New(idCategoria, dsSubCategoria);
            Add(subCategoria);
            return subCategoria.Id;
        }
        public static void Add(SubCategoria subCategoria)
        {
            SubCategoriaRepository repository = Repository;
            repository.Add(subCategoria.DbSetSubCategoria);
            repository.Salve();
        }
        public static SubCategoria New(int idCategoria, string dsSubCategoria)
        {
            return new SubCategoria(idCategoria, dsSubCategoria);
        }
        public static SubCategoria New(DbSetSubCategoria dbSetSubCategoria)
        {
            return new SubCategoria(dbSetSubCategoria);
        }
        public static void Change(SubCategoria subCategoria)
        {
            Repository.Update(subCategoria.DbSetSubCategoria);
        }
        public static void Remove(SubCategoria subCategoria)
        {
            Repository.Remove(subCategoria.DbSetSubCategoria);
        }
        public static SubCategoria? GetId(int id)
        {
            DbSetSubCategoria? dbSetSubCategoria = Repository.GetId(id);
            if (dbSetSubCategoria == null) return null;
            SubCategoria subCategoria = New(dbSetSubCategoria);
            return subCategoria;
        }
        public static SubCategoria? First
        {
            get
            {
                DbSetSubCategoria? dbSetSubCategoria = Repository.GetFirst();
                if (dbSetSubCategoria == null) return null;
                SubCategoria subCategoria = New(dbSetSubCategoria);
                return subCategoria;
            }
        }
        public static SubCategoria? GetFirstCategoria(int id)
        {
            DbSetSubCategoria? dbSetSubCategoria = Repository.GetFirstCategoria(id);
            if (dbSetSubCategoria == null) return null;
            SubCategoria subCategoria = New(dbSetSubCategoria);
            return subCategoria;
        }
        public static List<SubCategoria>? GetAll
        {
            get
            {
                SubCategoriaRepository subCategoriaRepository = new();
                List<DbSetSubCategoria> dbSetSubCategorias = subCategoriaRepository.GetAll();
                if (dbSetSubCategorias == null) return null;
                List<SubCategoria> subCategorias = new();
                foreach (DbSetSubCategoria dbSetSubCategoria in dbSetSubCategorias)
                    subCategorias.Add(New(dbSetSubCategoria));
                return subCategorias;
            }
        }
    }

}

