using CGController;
using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGTeste
{
    public class LancamentoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            LancamentoController lancamentoController = new();
            int id = 0;
            int idCategoria = GetIdCategoria();
            int idSubCategoria = GetIdSubCategoria(idCategoria);
            string descricaoLancamento = String.Format("Novo Lancamento {0}", Guid.NewGuid().ToString()[..5]);
            Double valorLancamento = 10000.99;
            bool recorrente = false;
            int idNewLancamento = lancamentoController.Adicionar(DateTime.Now, GetIdFavorecido(), GetIdPagador(), GetIdModalidade(), GetIdInstituicao(), idCategoria, idSubCategoria, GetIdForncedor(),
                descricaoLancamento, valorLancamento, recorrente);
            Lancamento? lancamento = lancamentoController.GetId(idNewLancamento);
            Assert.NotNull(lancamento);
            Assert.NotEqual(id, lancamento.Id);
            Assert.Equal(descricaoLancamento, lancamento.Descricao);

        }

        private static int GetIdFavorecido()
        {
            Favorecido? favorecido = FavorecidoController.GetFirst;
            if (favorecido != null) { return favorecido.Id; }
            else { return 0; }
        }

        private static int GetIdPagador()
        {
            PagadorController pagadorController = new();
            Pagador? pagador = pagadorController.GetFirst();
            if (pagador != null) { return pagador.Id; }
            else { return 0; }
        }
        private static int GetIdModalidade()
        {
            Modalidade? modalidade = ModalidadeController.GetFirst();
            if (modalidade != null) { return modalidade.Id; }
            else { return 0; }
        }
        private static int GetIdInstituicao()
        {
            Instituicao? instituicao = InstituicaoController.GetFirst;
            if (instituicao != null) { return instituicao.Id; }
            else { return 0; }
        }

        private static int GetIdCategoria()
        {
            Categoria? categoria = CategoriaController.GetFirst();
            if (categoria != null) { return categoria.Id; }
            else { return 0; }
        }

        private static int GetIdSubCategoria(int idCategoria)
        {
            SubCategoriaController subCategoriaController = new();
            SubCategoria? subcategoria = subCategoriaController.GetFirst(idCategoria);
            if (subcategoria != null) { return subcategoria.Id; }
            else { return 0; }
        }
        private static int GetIdForncedor()
        {
            Fornecedor? fornecedor = FornecedorController.GetFirst;
            if (fornecedor != null) { return fornecedor.Id; }
            else { return 0; }
        }



        /* [Fact]
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
            LancamentoRepository lancamento = new LancamentoRepository(id, dataLancamento, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente);
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
            LancamentoRepository lancamento = new LancamentoRepository(id, dataLancamento, idFavorecido, idPagador, idModalidade, idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente);
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
            Assert.Throws<ArgumentException>(() => new LancamentoRepository(id, dataLancamento, 0, idPagador, idModalidade,
                idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));
            Assert.Throws<ArgumentException>(() => new LancamentoRepository(id, dataLancamento, idFavorecido, 0, idModalidade,
                idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));
            Assert.Throws<ArgumentException>(() => new LancamentoRepository(id, dataLancamento, idFavorecido, idPagador, 0,
                idInstituicao, idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));
            Assert.Throws<ArgumentException>(() => new LancamentoRepository(id, dataLancamento, idFavorecido, idPagador, idModalidade, 0,
                idCategoria, idSubCategoria, idFornecedor, descricao, valor, recorrente));

        }*/
    }
}