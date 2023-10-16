using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class LancamentoUC
    {
        public LancamentoUC() { }
        public int Adicionar(DateTime data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria,
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            Lancamento lancamento = Criar(data, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria,
                idSubCategoria, idFornecedor, descricao, valor, recorrente);
            LancamentoRepository lancamentoRepository = new LancamentoRepository();
            lancamentoRepository.AdicionarDbSet(lancamento.DbSetLancamento);
            Salvar(lancamentoRepository);
            return lancamento.Id;
        }
        public Lancamento Criar(DateTime data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria,
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            return new Lancamento(data, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria,
                idSubCategoria, idFornecedor, descricao, valor, recorrente);
        }
        public Lancamento Criar(DbSetLancamento dbSetLancamento)
        {
            return new Lancamento(dbSetLancamento);
        }
        private void Salvar(LancamentoRepository lancamentoRepository)
        {
            lancamentoRepository.Salvar();
        }
        public Lancamento? GetId(int id)
        {
            LancamentoRepository lancamentoRepository = new LancamentoRepository();
            DbSetLancamento? dbSetLancamento = lancamentoRepository.DbSetGetId(id);
            if (dbSetLancamento == null) return null;
            Lancamento lancamento = Criar(dbSetLancamento);
            return lancamento;
        }
        public Lancamento? GetFirst()
        {
            LancamentoRepository lancamentoRepository = new LancamentoRepository();
            DbSetLancamento? dbSetLancamento = lancamentoRepository.DbSetGetFirst();
            if (dbSetLancamento == null) return null;
            Lancamento lancamento = Criar(dbSetLancamento);
            return lancamento;
        }
    }
}
