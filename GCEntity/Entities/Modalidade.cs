using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Modalidade
    {
        public DbSetModalidade DbSetModalidade { get; }
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
        public ICollection<Lancamento>? Lancamentos { get; set; }
        public Modalidade(int id, string descricao)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            DbSetModalidade = new DbSetModalidade();
            DbSetModalidade.Id = id;
            ValidaNome(descricao);
            DbSetModalidade.Descricao = descricao;
            this.Lancamentos = new List<Lancamento>();
        }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da modalidade não pode ser vazio ou nulo.");
            }
        }
    }
}
