using CGEntity.Entities;

namespace CGTeste


{
    public class PagadorTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string nomePagador = "Novo Pagador";
            Pagador pagador = new Pagador(id, nomePagador);
            Assert.Equal(id, pagador.Id);
            Assert.Equal(nomePagador, pagador.Nome);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string nomePagador = "Novo Pagador";
            Pagador pagador = new Pagador(id, nomePagador);
            Assert.NotEqual(id, pagador.Id);
            Assert.Equal(nomePagador, pagador.Nome);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string nomePagador = string.Empty;
            Assert.Throws<ArgumentException>(() => new Pagador(id, nomePagador));
        }
    }
}