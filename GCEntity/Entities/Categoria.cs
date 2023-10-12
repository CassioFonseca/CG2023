using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Categoria
    {
        public DbSetCategoria DbSetCategoria { get; }
        public int Id { get { return this.DbSetCategoria.Id; } }
        public string Descricao
        {
            get { return this.DbSetCategoria.Descricao; }
            set
            {
                if (value != this.DbSetCategoria.Descricao)
                {
                    ValidaDescricao(value);
                    this.DbSetCategoria.Descricao = value;
                }
            }
        }
        public ICollection<SubCategoria>? Subcategorias { get; set; }
        public Categoria(int id, string descricao)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            DbSetCategoria = new DbSetCategoria();
            DbSetCategoria.Id = id;
            ValidaDescricao(descricao);
            DbSetCategoria.Descricao = descricao;
            this.Subcategorias = new List<SubCategoria>();
        }
        private void ValidaDescricao(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da Categoria não pode ser vazio ou nulo.");
            }
        }
    }
}
