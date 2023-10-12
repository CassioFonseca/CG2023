using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{
    public class FornecedorRepository
    {
        private DbSetFornecedor DbSetFornecedor { get; set; }
        private DbContext DbContext { get; set; }
        public FornecedorRepository(Fornecedor fornecedor)
        {
            this.DbSetFornecedor = fornecedor.dbSetFornecedor;
            this.DbContext = new AppDbContext();
        }

        public int AdicionarFavorecido()
        {
            var favorecido = DbContext.Set<DbSetFornecedor>();
            this.DbSetFornecedor.Id = 0;
            favorecido.Add(this.DbSetFornecedor);
            SalvarCategoria();
            return this.DbSetFornecedor.Id;
        }

        public void SalvarCategoria()
        {
            this.DbContext.SaveChanges();
        }
    }
}
