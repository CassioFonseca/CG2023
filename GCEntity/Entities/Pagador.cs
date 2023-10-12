using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Pagador
    {
        public DbSetPagador DbSetPagador { get; }
        public int Id { get { return this.DbSetPagador.Id; } }
        public string Descricao
        {
            get { return this.DbSetPagador.Nome; }
            set
            {
                if (value != this.DbSetPagador.Nome)
                {
                    ValidaNome(value);
                    this.DbSetPagador.Nome = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; }
        public Pagador(int id, string nome)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            DbSetPagador = new DbSetPagador();
            DbSetPagador.Id = id;
            ValidaNome(nome);
            DbSetPagador.Nome = nome;
            this.Lancamentos = new List<Lancamento>();
        }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do pagador não pode ser vazio ou nulo.");
            }
        }
    }
}
