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
        public int Adicionar(string descricao)
        {
            return categoriaUC.Adicionar(descricao);
        }
        public Categoria Criar(string descricao)
        {
            return categoriaUC.Criar(descricao);
        }
        public Categoria? GetId(int id)
        {
            return categoriaUC.GetId(id);

        }
        public Categoria? GetFirst()
        {
            return categoriaUC.GetFirst();
        }

    }
}