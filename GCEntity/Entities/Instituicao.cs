using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Instituicao
    {
        public DbSetInstituicao dbSetInstituicao { get; }
        public int Id { get { return this.dbSetInstituicao.Id; } }
        public string Nome
        {
            get { return this.dbSetInstituicao.Nome; }
            set
            {
                if (value != this.dbSetInstituicao.Nome)
                {
                    ValidaNome(value);
                    this.dbSetInstituicao.Nome = value;
                }
            }
        }
        public ICollection<Lancamento>? Lancamentos { get; set; }
        public Instituicao(int id, string nome)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            dbSetInstituicao = new DbSetInstituicao();
            dbSetInstituicao.Id = id;
            ValidaNome(nome);
            dbSetInstituicao.Nome = nome;
            this.Lancamentos = new List<Lancamento>();
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
