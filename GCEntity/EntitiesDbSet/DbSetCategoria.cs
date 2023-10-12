using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetCategoria 
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Descricao { get; set; } = string.Empty;
        public ICollection<DbSetSubCategoria>? Subcategorias { get; set; }
        public ICollection<DbSetLancamento>? Lancamentos { get; set; }
    }
}
