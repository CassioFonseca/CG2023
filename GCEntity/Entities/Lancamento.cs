namespace CGEntity.Entities
{
    public class Lancamento
    {
        public int Id { get; }
        public DateOnly Data { get; set; }
        public int IdFavorecido { get; set; }
        public int IdPagador { get; set; }
        public int IdModalidade { get; set; }
        public int IdInstituicao { get; set; }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdFornecedor { get; set; }
        public string Descricao { get; set; } 
        public float Valor { get; set; }
        public bool Recorrente { get; set; }

        public Lancamento(int id, DateOnly data, int idFavorecido, int idPagador, int idModalidade, int idInstituicao, int idCategoria, int idSubCategoria, int idFornecedor, string descricao, float valor, bool recorrente)
        {
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
