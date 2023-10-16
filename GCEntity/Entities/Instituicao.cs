using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Instituicao
    {
        public DbSetInstituicao DbSetInstituicao { get; } = new DbSetInstituicao();
        public int Id { get { return this.DbSetInstituicao.Id; } }
        public string Nome
        {
            get { return this.DbSetInstituicao.Nome; }
            set
            {
                if (value != this.DbSetInstituicao.Nome)
                {
                    ValidaNome(value);
                    this.DbSetInstituicao.Nome = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; } = new List<Lancamento>();
        public Instituicao(string nome)
        {
            DbSetInstituicao = new DbSetInstituicao();
            ValidaNome(nome);
            DbSetInstituicao.Nome = nome;
        }
        public Instituicao(DbSetInstituicao dbSetInstituicao)
        {
            ValidaNome(dbSetInstituicao.Nome);
            DbSetInstituicao = dbSetInstituicao;
        }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da instituicão não pode ser vazio ou nulo.");
            }
        }

    }
}
