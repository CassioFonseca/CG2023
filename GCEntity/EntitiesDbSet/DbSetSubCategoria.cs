using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetSubCategoria
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public virtual string Descricao {  get; set; } = string.Empty;
        public virtual ICollection<DbSetLancamento>? Lancamentos { get; set; }
    }
}
