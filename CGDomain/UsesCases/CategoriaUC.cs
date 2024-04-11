using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class CategoriaUC
    {
        public CategoriaUC() { }
        public static int Adicionar(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException($"'{nameof(descricao)}' cannot be null or whitespace.", nameof(descricao));
            }

            Categoria categoria = Criar(descricao);
            CategoriaRepository categoriaRepository = new();
            categoriaRepository.AdicionarDbSet(categoria.DbSetCategoria);
            Salvar(categoriaRepository);
            return categoria.Id;
        }
        public static Categoria Criar(string descricao)
        {
            return new Categoria(descricao);
        }
        public static Categoria Criar(DbSetCategoria dbSetCategoria)
        {
            return new Categoria(dbSetCategoria);
        }
        private static void Salvar(CategoriaRepository categoriaRepository)
        {
            categoriaRepository.Salvar();
        }
        public static Categoria? GetId(int id)
        {
            CategoriaRepository categoriaRepository = new();
            DbSetCategoria? dbSetCategoria = categoriaRepository.DbSetGetId(id);
            if (dbSetCategoria == null) return null;
            Categoria categoria = Criar(dbSetCategoria);
            return categoria;
        }
        public static Categoria? First
        {
            get
            {
                CategoriaRepository categoriaRepository = new();
                DbSetCategoria? dbSetCategoria = categoriaRepository.DbSetGetFirst();
                if (dbSetCategoria == null) return null;
                Categoria categoria = Criar(dbSetCategoria);
                return categoria;
            }
        }
        public static List<Categoria>? GetAll
        {
            get
            {
                CategoriaRepository categoriaRepository = new();
                List<DbSetCategoria> dbSetCategorias = categoriaRepository.DbSetGetAll();
                if (dbSetCategorias == null) return null;
                List<Categoria> categorias = new();
                foreach (DbSetCategoria dbSetCategoria in dbSetCategorias)
                    categorias.Add(Criar(dbSetCategoria));
                return categorias;
            }
        }
    }
}
