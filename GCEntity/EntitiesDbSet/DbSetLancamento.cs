using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CGEntity.EntitiesDbSet
{
    public class DbSetLancamento
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; } = string.Empty;
        [DataType(DataType.Currency)]
        public double Valor { get; set; }
        public bool Recorrente { get; set; }
        public int CategoriaId { get; set; }
        public DbSetCategoria? Categoria { get; set; }
        public int? SubCategoriaId { get; set; }
        public DbSetSubCategoria? SubCategoria { get; set; }
        public int FavorecidoId { get; set; }
        public DbSetFavorecido? Favorecido { get; set; }
        public int? FornecedorId { get; set; }
        public DbSetFornecedor? Fornecedor { get; set; }
        public int InstituicaoId { get; set; }
        public DbSetInstituicao? Instituicao { get; set; }
        public int ModalidadeId { get; set; }
        public DbSetModalidade? Modalidade { get; set; }
        public int PagadorId { get; set; }
        public DbSetPagador? Pagador { get; set; }
    }
}
