using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class CategoriaUC
    {
        public CategoriaUC() { }
        public int Adicionar(string descricao)
        {
            Categoria categoria = Criar(descricao);
            CategoriaRepository categoriaRepository = new CategoriaRepository();
            categoriaRepository.AdicionarDbSet(categoria.DbSetCategoria);
            Salvar(categoriaRepository);
            return categoria.Id;
        }
        public Categoria Criar(string descricao)
        {
            return new Categoria(descricao);
        }
        public Categoria Criar(DbSetCategoria dbSetCategoria)
        {
            return new Categoria(dbSetCategoria);
        }
        private void Salvar(CategoriaRepository categoriaRepository)
        {
            categoriaRepository.Salvar();
        }
        public Categoria? GetId(int id)
        {
            CategoriaRepository categoriaRepository = new CategoriaRepository();
            DbSetCategoria? dbSetCategoria = categoriaRepository.DbSetGetId(id);
            if (dbSetCategoria == null) return null;
            Categoria categoria = Criar(dbSetCategoria);
            return categoria;
        }
        public Categoria? GetFirst()
        {
            CategoriaRepository categoriaRepository = new CategoriaRepository();
            DbSetCategoria? dbSetCategoria = categoriaRepository.DbSetGetFirst();
            if (dbSetCategoria == null) return null;
            Categoria categoria = Criar(dbSetCategoria);
            return categoria;
        }
    }
}
