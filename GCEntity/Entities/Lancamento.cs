using System;
using System.ComponentModel;

namespace CGEntity.Entities
{
    public class Lancamento
    {
        public int Id { get; }
        public DateOnly Data { get; set; }
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
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Recorrente { get; set; }

        public Lancamento(int id, DateOnly data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria, 
            int idSubCategoria, int idFornecedor, string descricao, double valor, bool recorrente)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            Id = id;
            Data = data;
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
