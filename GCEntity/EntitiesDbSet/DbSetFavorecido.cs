using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetFavorecido
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public virtual string Nome {  get; set; } = string.Empty;
        public virtual ICollection<DbSetLancamento>? Lancamentos { get; set; }
    }
}
