using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class SubCategoria
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Descricao {  get; set; }
    }
}
