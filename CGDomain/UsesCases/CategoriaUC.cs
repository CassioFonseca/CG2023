using CGEntity.Entities;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class CategoriaUC
    {
        
        public CategoriaUC() 
        {
        }
        public int AdicionarCategoria(int id, string descricao)
        {
            Categoria categoria = CriarCategoria(id, descricao);
            CategoriaRepository categoriaRepository = new CategoriaRepository(categoria);
            return categoriaRepository.AdicionarCategoria();
        }
        public Categoria CriarCategoria(int id, string descricao)
        {
            return new Categoria(id, descricao);
        }
    }
}
