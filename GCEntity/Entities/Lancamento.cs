using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Lancamento
    {
        public DbSetLancamento DbSetLancamento { get; } = new DbSetLancamento();
        public int Id { get { return this.DbSetLancamento.Id; } }
        public DateTime DataLancamento
        {
            get { return this.DbSetLancamento.Data; }
            set
            {
                if (value != this.DbSetLancamento.Data) { this.DbSetLancamento.Data = value; }
            }
        }
        public string Descricao
        {
            get { return this.DbSetLancamento.Descricao; }
            set
            {
                if (value != this.DbSetLancamento.Descricao) { this.DbSetLancamento.Descricao = value; }
            }
        }
        public double Valor
        {
            get { return this.DbSetLancamento.Valor; }
            set
            {
                if (value != this.DbSetLancamento.Valor) { this.DbSetLancamento.Valor = value; }
            }
        }
        public bool Recorrente
        {
            get { return this.DbSetLancamento.Recorrente; }
            set
            {
                if (value = !this.DbSetLancamento.Recorrente) { this.DbSetLancamento.Recorrente = value; }
            }
        }
        public int FavorecidoId
        {
            get { return this.DbSetLancamento.FavorecidoId; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de favorecido inválido!"); }
                if (this.DbSetLancamento.FavorecidoId != value) { this.DbSetLancamento.FavorecidoId = value; }
            }
        }
        public int PagadorId
        {
            get { return this.DbSetLancamento.PagadorId; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de pagador inválido!"); }
                if (this.DbSetLancamento.PagadorId != value) { this.DbSetLancamento.PagadorId = value; }
            }
        }
        public int ModalidadeId
        {
            get { return this.DbSetLancamento.ModalidadeId; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de modalidade inválido!"); }
                if (this.DbSetLancamento.ModalidadeId != value) { this.DbSetLancamento.ModalidadeId = value; }
            }
        }
        public int InstituicaoId
        {
            get { return this.DbSetLancamento.InstituicaoId; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de instituição inválido!"); }
                if (this.DbSetLancamento.InstituicaoId != value) { this.DbSetLancamento.InstituicaoId = value; }
            }
        }
        public int CategoriaId
        {
            get { return this.DbSetLancamento.CategoriaId; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de Categoria inválido!"); }
                if (this.DbSetLancamento.CategoriaId != value) { this.DbSetLancamento.CategoriaId = value; }
            }
        }
        public int? SubCategoriaId
        {
            get { return this.DbSetLancamento.SubCategoriaId; }
            set
            {
                if (this.DbSetLancamento.SubCategoriaId != value) { this.DbSetLancamento.SubCategoriaId = value; }
            }
        }
        public int? FornecedorId
        {
            get { return this.DbSetLancamento.FornecedorId; }
            set
            {
                if (this.DbSetLancamento.FornecedorId != value) { this.DbSetLancamento.FornecedorId = value; }
            }
        }

        public Lancamento(DateTime data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria,
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            DbSetLancamento = new()
            {
                Data = data,
                FavorecidoId = idFavorecido,
                PagadorId = idPagador,
                ModalidadeId = idModalidade,
                InstituicaoId = idInstituicao,
                CategoriaId = idCategoria,
                SubCategoriaId = idSubCategoria,
                FornecedorId = idFornecedor
            };
            Descricao = descricao;
            Valor = valor;
            Recorrente = recorrente;
        }
        public Lancamento(DbSetLancamento dbSetLancamento)
        {
            this.DbSetLancamento = dbSetLancamento;
        }
    }
}
