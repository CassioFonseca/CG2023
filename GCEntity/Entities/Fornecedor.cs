using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Fornecedor
    {
        public DbSetFornecedor dbSetFornecedor { get; }
        public int Id { get { return this.dbSetFornecedor.Id; } }
        public string Nome
        {
            get { return this.dbSetFornecedor.Nome; }
            set
            {
                if (value != this.dbSetFornecedor.Nome)
                {
                    ValidaNome(value);
                    this.dbSetFornecedor.Nome = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; }
        public Fornecedor(int id, string nome)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            dbSetFornecedor = new DbSetFornecedor();
            dbSetFornecedor.Id = id;
            ValidaNome(nome);
            dbSetFornecedor.Nome = nome;
            this.Lancamentos = new List<Lancamento>();
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
