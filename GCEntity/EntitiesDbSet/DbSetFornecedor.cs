using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetFornecedor
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)] 
        public string Nome { get; set; } = string.Empty;
        [ForeignKey("Id")]
        public List<DbSetLancamento>? Lancamentos { get; set; }
    }
}
