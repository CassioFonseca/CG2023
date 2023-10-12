using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetLancamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; } = string.Empty;
        [DataType(DataType.Currency)] 
        public double Valor { get; set; }
        public bool Recorrente { get; set; }
    }
}
