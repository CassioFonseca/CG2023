using CGEntity.Entities;

namespace CGServer.Repository
{
    public class InstituicaoRepository
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
        public ICollection<Lancamento> Lancamentos { get; set; }
        public InstituicaoRepository(int id, string nome)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            this.Id = id;
            ValidaNome(nome);
            this._nome = nome;
            this.Nome = nome;
            this.Lancamentos = new List<Lancamento>();
        }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da instituição não pode ser vazio ou nulo.");
            }
        }
    }
}
