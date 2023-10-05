namespace CGEntity.Entities
{
    public class Fornecedor
    {
        public int Id { get; }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != _nome)
                {
                    ValidaNome(value);
                    this._nome = value;
                }
            }
        }
        public Fornecedor(int id, string nome)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            this.Id = id;
            ValidaNome(nome);
            this._nome = nome;
            this.Nome = nome;
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
