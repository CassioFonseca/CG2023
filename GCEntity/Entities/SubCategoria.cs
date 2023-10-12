using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class SubCategoria
    {
        public DbSetSubCategoria DbSetSubCategoria { get; }
        public ICollection<Lancamento>? Lancamentos { get; set; }
        public int? CategoriaId { get; set; }
        public int Id { get { return this.DbSetSubCategoria.Id; } }
        public string Descricao
        {
            get { return this.DbSetSubCategoria.Descricao; }
            set
            {
                if (value != this.DbSetSubCategoria.Descricao)
                {
                    ValidaDescricao(value);
                    this.DbSetSubCategoria.Descricao = value;
                }
            }
        }
        public SubCategoria(int id, int idCategoria, string descricao)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            DbSetSubCategoria = new DbSetSubCategoria();
            DbSetSubCategoria.Id = id;
            ValidaDescricao(descricao);
            DbSetSubCategoria.Descricao = descricao;
            if (idCategoria > 0) { this.CategoriaId = idCategoria; }
            else { this.CategoriaId = null; }
            this.Lancamentos = new List<Lancamento>();
        }
        private void ValidaDescricao(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da sub categoria não pode ser vazio ou nulo.");
            }
        }
    }
}
