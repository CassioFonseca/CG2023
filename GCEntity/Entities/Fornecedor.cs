using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Fornecedor
    {
        public DbSetFornecedor DbSetFornecedor { get; } = new DbSetFornecedor();
        public int Id { get { return this.DbSetFornecedor.Id; } }
        public string Nome
        {
            get { return this.DbSetFornecedor.Nome; }
            set
            {
                if (value != this.DbSetFornecedor.Nome)
                {
                    ValidaNome(value);
                    this.DbSetFornecedor.Nome = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; } = new List<Lancamento>();
        public Fornecedor(string value)
        {
            ValidaNome(value);
            DbSetFornecedor.Nome = value;
        }
        public Fornecedor(DbSetFornecedor dbSetFornecedor)
        {
            ValidaNome(dbSetFornecedor.Nome);
            DbSetFornecedor = dbSetFornecedor;
        }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do fornecedor não pode ser vazio ou nulo.");
            }
        }
    }
}
