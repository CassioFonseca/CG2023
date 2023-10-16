using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetCategoria 
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Descricao { get; set; } = string.Empty;
        [ForeignKey("Id")]
        public List<DbSetSubCategoria>? SubCategorias { get; set; }
        [ForeignKey("Id")]
        public List<DbSetLancamento>? Lancamentos { get; set; }
    }
}
