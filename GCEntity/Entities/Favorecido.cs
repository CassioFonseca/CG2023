using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Favorecido
    {
        public DbSetFavorecido DbSetFavorecido { get; }
        public int Id { get { return this.DbSetFavorecido.Id; } }
        public string Nome
        {
            get { return this.DbSetFavorecido.Nome; }
            set
            {
                if (value != this.DbSetFavorecido.Nome)
                {
                    ValidaNome(value);
                    this.DbSetFavorecido.Nome = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do favorecido não pode ser vazio ou nulo.");
            }
        }
        public Favorecido(string nome)
        {
            DbSetFavorecido = new DbSetFavorecido();
            ValidaNome(nome);
            DbSetFavorecido.Nome = nome;           
            this.Lancamentos = new List<Lancamento>();
        }

        public Favorecido(DbSetFavorecido dbSetFavorecido)
        {
            ValidaNome(dbSetFavorecido.Nome);
            DbSetFavorecido = dbSetFavorecido;
            this.Lancamentos = new List<Lancamento>();
        }
    }
}
