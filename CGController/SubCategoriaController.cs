using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class SubCategoriaController
    {
        private SubCategoriaUC SubCategoriaUC;
        public SubCategoriaController()
        {
            this.SubCategoriaUC = new SubCategoriaUC();
        }
        public int Adicionar(int idCategoria, string descSubCategoria)
        {
            return SubCategoriaUC.Adicionar(idCategoria, descSubCategoria);
        }
        public SubCategoria Criar(int idCategoria, string descSubCategoria)
        {
            return SubCategoriaUC.Criar(idCategoria, descSubCategoria);
        }
        public SubCategoria? GetId(int id)
        {
            return SubCategoriaUC.GetId(id);
        }
        public SubCategoria? GetFirst()
        {
            return SubCategoriaUC.GetFirst();
        }
        public SubCategoria? GetFirst(int idCategoria)
        {
            return SubCategoriaUC.GetFirst(idCategoria);
        }
    }
}
