using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Categoria
    {
        public DbSetCategoria DbSetCategoria { get; } = new DbSetCategoria();
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
        private ICollection<SubCategoria> SubCategorias { get; set; } = new List<SubCategoria>();
        public ICollection<Lancamento>? Lancamentos { get; set; } = new List<Lancamento>();
        private static void ValidaDescricao(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome da categoria não pode ser vazio ou nulo.");
            }
        }
        public Categoria(string descricao)
        {
            ValidaDescricao(descricao);
            DbSetCategoria.Descricao = descricao;
        }
        public Categoria(DbSetCategoria dbSetCategoria)
        {
            ValidaDescricao(dbSetCategoria.Descricao);
            DbSetCategoria = dbSetCategoria;
        }
    }
}
