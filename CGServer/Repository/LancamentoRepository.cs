using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class LancamentoRepository
    {
        private DbSetLancamento DbSetLancamento { get; set; }
        private DbContext DbContext { get; set; }
        public LancamentoRepository(Lancamento lancamento)
        {
            this.DbSetLancamento = lancamento.DbSetLancamento;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarFavorecido()
        {
            var lancamento = DbContext.Set<DbSetLancamento>();
            this.DbSetLancamento.Id = 0;
            lancamento.Add(this.DbSetLancamento);
            SalvarCategoria();
            return this.DbSetLancamento.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
