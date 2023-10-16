using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class PagadorController
    {
        private PagadorUC PagadorUC;
        public PagadorController()
        {
            this.PagadorUC = new PagadorUC();
        }
        public int Adicionar(string nome)
        {
            return PagadorUC.Adicionar(nome);
        }
        public Pagador Criar(string nome)
        {
            return PagadorUC.Criar(nome);
        }
        public Pagador? GetId(int id)
        {
            return PagadorUC.GetId(id);

        }
        public Pagador? GetFirst()
        {
            return PagadorUC.GetFirst();

        }
    }
}