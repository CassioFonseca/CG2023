﻿using System.ComponentModel.DataAnnotations;

namespace CGEntity.Entities
{
    public class SubCategoria
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Descricao {  get; set; }
        public ICollection<Lancamento> Lancamentos { get; set; }
    }
}
