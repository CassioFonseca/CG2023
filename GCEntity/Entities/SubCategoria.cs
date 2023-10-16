using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class SubCategoria
    {
        public DbSetSubCategoria DbSetSubCategoria { get; } = new DbSetSubCategoria();
        public ICollection<Lancamento>? Lancamentos { get; set; } = new List<Lancamento>();
        public int? CategoriaId { get { return this.DbSetSubCategoria.Id; } }
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
        public SubCategoria(int idCategoria, string descricao)
        {
            ValidaDescricao(descricao);
            this.DbSetSubCategoria.Descricao = descricao;
            this.DbSetSubCategoria.CategoriaId = idCategoria;
        }
        public SubCategoria(DbSetSubCategoria dbSetSubCategoria)
        {
            ValidaDescricao(dbSetSubCategoria.Descricao);
            this.DbSetSubCategoria = dbSetSubCategoria;
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
