using CGServer.Repository;

namespace CGTeste


{
    public class CategoriaRepositoryTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string descricaoCategoria = "Nova categoria";
            CategoriaRepository categoria = new CategoriaRepository(id, descricaoCategoria);
            Assert.Equal(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string descricaoCategoria = "Nova categoria";
            CategoriaRepository categoria = new CategoriaRepository(id, descricaoCategoria);
            Assert.NotEqual(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string descricaoCategoria = string.Empty;
            Assert.Throws<ArgumentException>(() => new CategoriaRepository(id, descricaoCategoria));
        }
    }
}