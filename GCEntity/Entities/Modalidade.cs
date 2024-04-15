using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Modalidade
    {
        public DbSetModalidade DbSetModalidade { get; } = new DbSetModalidade();
        public int Id { get { return this.DbSetModalidade.Id; } }
        public string Descricao
        {
            get { return this.DbSetModalidade.Descricao; }
            set
            {
                if (value != this.DbSetModalidade.Descricao)
                {
                    ValidaNome(value);
                    this.DbSetModalidade.Descricao = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; } = new List<Lancamento>();
        public Modalidade(string descricao)
        {
            DbSetModalidade = new DbSetModalidade();
            ValidaNome(descricao);
            DbSetModalidade.Descricao = descricao;
        }
        public Modalidade(DbSetModalidade dbSetModalidade)
        {
            ValidaNome(dbSetModalidade.Descricao);
            DbSetModalidade = dbSetModalidade;
        }
        private static void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da modalidade não pode ser vazio ou nulo.");
            }
        }
    }
}
