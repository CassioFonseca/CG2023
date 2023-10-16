using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class FornecedorUC
    {
        public FornecedorUC() { }
        public int Adicionar(string value)
        {
            Fornecedor fornecedor = Criar(value);
            FornecedorRepository fornecedorRepository = new FornecedorRepository();
            fornecedorRepository.AdicionarDbSet(fornecedor.DbSetFornecedor);
            Salvar(fornecedorRepository);
            return fornecedor.Id;
        }
        public Fornecedor Criar(string value)
        {
            return new Fornecedor(value);
        }
        public Fornecedor Criar(DbSetFornecedor dbSetFornecedor)
        {
            return new Fornecedor(dbSetFornecedor);
        }
        private void Salvar(FornecedorRepository fornecedorRepository)
        {
            fornecedorRepository.Salvar();
        }

        public Fornecedor? GetId(int id)
        {
            FornecedorRepository fornecedorRepository = new FornecedorRepository();
            DbSetFornecedor? dbSetFornecedor = fornecedorRepository.DbSetGetId(id);
            if (dbSetFornecedor == null) return null;
            Fornecedor fornecedor = Criar(dbSetFornecedor);
            return fornecedor;
        }
        public Fornecedor? GetFirst()
        {
            FornecedorRepository fornecedorRepository = new FornecedorRepository();
            DbSetFornecedor? dbSetFornecedor = fornecedorRepository.DbSetGetFirst();
            if (dbSetFornecedor == null) return null;
            Fornecedor fornecedor = Criar(dbSetFornecedor);
            return fornecedor;
        }
    }
}
