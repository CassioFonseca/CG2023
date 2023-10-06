using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class Lancamento
    {
        public int Id { get; set; }
        public DateOnly Data { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        [DataType(DataType.Currency)] 
        public double Valor { get; set; }
        public bool Recorrente { get; set; }
    }
}
