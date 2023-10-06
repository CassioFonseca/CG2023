using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class Modalidade
    {
        public int Id { get; set; }
        [MaxLength(100)] 
        public string Descricao {  get; set; }
    }
}