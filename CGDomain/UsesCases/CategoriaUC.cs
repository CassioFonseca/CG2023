using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class CategoriaUC
    {
        public CategoriaUC() { }
        private static CategoriaRepository Repository
        {
            get { return new(); }
        }
        public static int Add(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException($"'{nameof(descricao)}' cannot be null or whitespace.", nameof(descricao));
            }

            Categoria categoria = New(descricao);
            Add(categoria);
            return categoria.Id;
        }
        public static void Add(Categoria categoria)
        {
            CategoriaRepository repository = Repository;
            repository.Add(categoria.DbSetCategoria);
            repository.Salve();
        }
        public static Categoria New(string descricao)
        {
            return new Categoria(descricao);
        }
        public static Categoria New(DbSetCategoria dbSetCategoria)
        {
            return new Categoria(dbSetCategoria);
        }
        public static void Change(Categoria categoria)
        {
            Repository.Update(categoria.DbSetCategoria);
        }
        public static void Remove(Categoria categoria)
        {
            Repository.Remove(categoria.DbSetCategoria);
        }
        public static Categoria? GetId(int id)
        {
            DbSetCategoria? dbSetCategoria = Repository.GetId(id);
            if (dbSetCategoria == null) return null;
            Categoria categoria = New(dbSetCategoria);
            return categoria;
        }
        public static Categoria? First
        {
            get
            {
                DbSetCategoria? dbSetCategoria = Repository.GetFirst();
                if (dbSetCategoria == null) return null;
                Categoria categoria = New(dbSetCategoria);
                return categoria;
            }
        }
        public static List<Categoria>? GetAll
        {
            get
            {
                List<DbSetCategoria> dbSetCategorias = Repository.GetAll();
                if (dbSetCategorias == null) return null;
                List<Categoria> categorias = new();
                foreach (DbSetCategoria dbSetCategoria in dbSetCategorias)
                    categorias.Add(New(dbSetCategoria));
                return categorias;
            }
        }
    }
}
