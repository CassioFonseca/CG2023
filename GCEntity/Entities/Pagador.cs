using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class Pagador
    {
        public int Id { get; set; }
        [MaxLength(100)] 
        public string Nome {  get; set; }
    }
}
