using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetFornecedor
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public string Nome { get; set; } = string.Empty;
        public ICollection<DbSetLancamento>? Lancamentos { get; set; }
    }
}
