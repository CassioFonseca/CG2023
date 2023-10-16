using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Pagador
    {
        public DbSetPagador DbSetPagador { get; } = new DbSetPagador();
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
        public ICollection<Lancamento>? Lancamentos { get; set; } = new List<Lancamento>();
        public Pagador(string nome)
        {
            DbSetPagador = new DbSetPagador();
            ValidaNome(nome);
            DbSetPagador.Nome = nome;
        }
        public Pagador(DbSetPagador dbSetPagador)
        {
            ValidaNome(dbSetPagador.Nome);
            DbSetPagador = dbSetPagador;
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
