using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetInstituicao
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public virtual string Nome {  get; set; } = string.Empty;
        public ICollection<DbSetLancamento> Lancamentos { get; set; }
    }
}
