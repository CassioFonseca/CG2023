using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        [MaxLength(100)] 
        public string Nome { get; set; }
    }
}
