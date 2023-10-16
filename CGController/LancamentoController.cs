using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class LancamentoController
    {
        private LancamentoUC LancamentoUC;
        public LancamentoController()
        {
            this.LancamentoUC = new LancamentoUC();
        }
        public int Adicionar(DateTime data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria,
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            return LancamentoUC.Adicionar(data, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria,
                idSubCategoria, idFornecedor, descricao, valor, recorrente);
        }
        public Lancamento Criar(DateTime data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria,
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            return LancamentoUC.Criar(data, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria,
                idSubCategoria, idFornecedor, descricao, valor, recorrente);
        }
        public Lancamento? GetId(int id)
        {
            return LancamentoUC.GetId(id);

        }
        public Lancamento? GetFirst()
        {
            return LancamentoUC.GetFirst();

        }
    }
}