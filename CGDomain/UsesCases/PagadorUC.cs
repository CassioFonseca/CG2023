using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class PagadorUC
    {
        public PagadorUC() { }
        public int Adicionar(string value)
        {
            Pagador pagador = Criar(value);
            PagadorRepository pagadorRepository = new PagadorRepository();
            pagadorRepository.AdicionarDbSet(pagador.DbSetPagador);
            Salvar(pagadorRepository);
            return pagador.Id;
        }
        public Pagador Criar(string value)
        {
            return new Pagador(value);
        }
        public Pagador Criar(DbSetPagador dbSetPagador)
        {
            return new Pagador(dbSetPagador);
        }
        private void Salvar(PagadorRepository pagadorRepository)
        {
            pagadorRepository.Salvar();
        }
        public Pagador? GetId(int id)
        {
            PagadorRepository pagadorRepository = new PagadorRepository();
            DbSetPagador? dbSetPagador = pagadorRepository.DbSetGetId(id);
            if (dbSetPagador == null) return null;
            Pagador pagador = Criar(dbSetPagador);
            return pagador;
        }
        public Pagador? GetFirst()
        {
            PagadorRepository pagadorRepository = new PagadorRepository();
            DbSetPagador? dbSetPagador = pagadorRepository.DbSetGetFirst();
            if (dbSetPagador == null) return null;
            Pagador pagador = Criar(dbSetPagador);
            return pagador;
        }
    }
}
