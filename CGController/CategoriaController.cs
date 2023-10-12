using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class CategoriaController
    {
        private CategoriaUC categoriaUC;
        public CategoriaController() 
        { 
            this.categoriaUC = new CategoriaUC();
        }
        public void AdicionarCategoria(int id, string descricao)
        {
            categoriaUC.AdicionarCategoria(id, descricao);
        }
        public Categoria CriarCategoria(int id, string descricao)
        {
            return categoriaUC.CriarCategoria(id, descricao);
        }

    }
}