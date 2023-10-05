using CGEntity.Entities;

namespace CGTeste


{
    public class LancamentoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            DateOnly dataLancamento = new DateOnly();
            int idFavorecido = 2;
            int idPagador = 3;
            int idModalidade = 4;
            int idInstituicao = 5;
            int idCategoria = 6;
            int idSubCategoria = 7;
            int idFornecedor = 8;
            string descricao = "Nova descricao";
            double valor = 1000.30;
            bool recorrente = false;
            Lancamento lancamento = new Lancamento(id, dataLancamento, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente);
            Assert.Equal(id, lancamento.Id);
            Assert.Equal(dataLancamento, lancamento.Data);
            Assert.Equal(idFavorecido, lancamento.IdFavorecido);
            Assert.Equal(idPagador, lancamento.IdPagador);
            Assert.Equal(idModalidade, lancamento.IdModalidade);
            Assert.Equal(idInstituicao, lancamento.IdInstituicao);
            Assert.Equal(idCategoria, lancamento.IdCategoria);
            Assert.Equal(idSubCategoria, lancamento.IdSubCategoria);
            Assert.Equal(idFornecedor, lancamento.IdFornecedor);
            Assert.Equal(descricao, lancamento.Descricao);
            Assert.Equal(valor, lancamento.Valor);
            Assert.Equal(recorrente, lancamento.Recorrente);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            DateOnly dataLancamento = new DateOnly();
            int idFavorecido = 2;
            int idPagador = 3;
            int idModalidade = 4;
            int idInstituicao = 5;
            int idCategoria = 6;
            int idSubCategoria = 7;
            int idFornecedor = 8;
            string descricao = "Nova descricao";
            double valor = 1000.30;
            bool recorrente = false;
            Lancamento lancamento = new Lancamento(id, dataLancamento, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente);
            Assert.NotEqual(id, lancamento.Id);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            DateOnly dataLancamento = new DateOnly();
            int idFavorecido = 2;
            int idPagador = 3;
            int idModalidade = 4;
            int idInstituicao = 5;
            int idCategoria = 6;
            int idSubCategoria = 7;
            int idFornecedor = 8;
            string descricao = "Nova descricao";
            double valor = 1000.30;
            bool recorrente = false;
            Assert.Throws<ArgumentException>(() => new Lancamento(id, dataLancamento, 0, idPagador, idModalidade,
                idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));
            Assert.Throws<ArgumentException>(() => new Lancamento(id, dataLancamento, idFavorecido, 0, idModalidade,
                idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));
            Assert.Throws<ArgumentException>(() => new Lancamento(id, dataLancamento, idFavorecido, idPagador, 0,
                idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));
            Assert.Throws<ArgumentException>(() => new Lancamento(id, dataLancamento, idFavorecido, idPagador, idModalidade, 0,
                idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));

        }
    }
}