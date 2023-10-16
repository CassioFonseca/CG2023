using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetSubCategoria
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Descricao {  get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public DbSetCategoria? Categoria { get; set; }
        [ForeignKey("Id")]
        public List<DbSetLancamento>? Lancamentos { get; set; }
    }
}
