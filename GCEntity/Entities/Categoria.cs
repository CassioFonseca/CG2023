using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Categoria:DbSetCategoria
    {
        private string _descricao;
        public override string Descricao
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
        public Categoria(int id, string descricao)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            this.Id = id;
            ValidaDescricao(descricao);
            this._descricao = descricao;
            this.Descricao = descricao;
            this.Subcategorias = new List<DbSetSubCategoria>();
            this.Lancamentos = new List<DbSetLancamento>();
        }
        private void ValidaDescricao(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do favorecido não pode ser vazio ou nulo.");
            }
        }
    }
}
