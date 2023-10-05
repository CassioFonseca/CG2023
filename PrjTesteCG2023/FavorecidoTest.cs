using CGEntity.Entities;

namespace CGTeste


{
    public class FavorecidoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string nomeFavorecido = "Novo Favorecido";
            Favorecido favorecido = new Favorecido(id, nomeFavorecido);
            Assert.Equal(id, favorecido.Id);
            Assert.Equal(nomeFavorecido, favorecido.Nome);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string nomeFavorecido = "Novo Favorecido";
            Favorecido favorecido = new Favorecido(id, nomeFavorecido);
            Assert.NotEqual(id, favorecido.Id);
            Assert.Equal(nomeFavorecido, favorecido.Nome);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string nomeFavorecido = string.Empty;
            Assert.Throws<ArgumentException>(() => new Favorecido(id, nomeFavorecido));
        }
    }
}