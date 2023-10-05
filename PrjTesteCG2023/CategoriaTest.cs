using CGEntity.Entities;

namespace CGTeste


{
    public class CategoriaTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string descricaoCategoria = "Nova categoria";
            Categoria categoria = new Categoria(id, descricaoCategoria);
            Assert.Equal(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string descricaoCategoria = "Nova categoria";
            Categoria categoria = new Categoria(id, descricaoCategoria);
            Assert.NotEqual(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string descricaoCategoria = string.Empty;
            Assert.Throws<ArgumentException>(() => new Categoria(id, descricaoCategoria));
        }
    }
}