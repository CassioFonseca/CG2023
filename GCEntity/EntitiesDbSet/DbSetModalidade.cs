using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetModalidade
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public virtual string Descricao {  get; set; } = string.Empty;
        public ICollection<DbSetLancamento> Lancamentos { get; set; }
    }
}