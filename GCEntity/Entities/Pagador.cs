using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class Pagador
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public string Nome {  get; set; }
        public ICollection<Lancamento> Lancamentos { get; set; }
    }
}
