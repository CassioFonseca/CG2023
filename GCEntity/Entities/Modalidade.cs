using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Modalidade:DbSetModalidade
    {
        public int Id { get; }
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (value != _descricao)
                {
                    ValidaDescricao(value);
                    this._descricao = value;
                }
            }
        }
        public ICollection<Lancamento> Lancamentos { get; set; }
        public Modalidade(int id, string descricao)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            this.Id = id;
            ValidaDescricao(descricao);
            this._descricao = descricao;
            this.Descricao = descricao;
            this.Lancamentos = new List<Lancamento>();
        }
        private void ValidaDescricao(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da modalidade não pode ser vazio ou nulo.");
            }
        }
    }
}
