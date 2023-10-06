using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public ICollection<SubCategoria> Subcategorias { get; set; }
    }
}
