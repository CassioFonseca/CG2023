using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Lancamento
    {
        public DbSetLancamento DbSetLancamento { get; }
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
                if (value != this.DbSetLancamento.Descricao)
                {
                    this.DbSetLancamento.Descricao = value;
                }
            }
        }
        public double Valor 
        { get { return this.DbSetLancamento.Valor; }
            set
            {
                if (value != this.DbSetLancamento.Valor)
                { 
                    this.DbSetLancamento.Valor = value; 
                }
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
        int _idFavorecido;
        public int IdFavorecido
        {
            get { return _idFavorecido; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de favorecido inválido!"); }
                if (_idFavorecido != value) { _idFavorecido = value; }
            }
        }
        int _idPagador;
        public int IdPagador
        {
            get { return _idPagador; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de pagador inválido!"); }
                if (_idPagador != value) { _idPagador = value; }
            }
        }
        int _idModalidade;
        public int IdModalidade
        {
            get { return _idModalidade; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de modalidade inválido!"); }
                if (_idModalidade != value) { _idModalidade = value; }
            }
        }
        int _idInstuicao;
        public int IdInstituicao
        {
            get { return _idInstuicao; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Id de instituição inválido!"); }
                if (_idInstuicao != value) { _idInstuicao = value; }
            }
        }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdFornecedor { get; set; }

        public Lancamento(int id, DateTime data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria,
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            DbSetLancamento = new DbSetLancamento();
            DbSetLancamento.Id = id;
            DbSetLancamento.Data = data;
            IdFavorecido = idFavorecido;
            IdPagador = idPagador;
            IdModalidade = idModalidade;
            IdInstituicao = idInstituicao;
            IdCategoria = idCategoria;
            IdSubCategoria = idSubCategoria;
            IdFornecedor = idFornecedor;
            Descricao = descricao;
            Valor = valor;
            Recorrente = recorrente;
        }
    }
}
