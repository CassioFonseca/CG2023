using CGEntity.Entities;

namespace CGTeste


{
    public class SubCategoriaTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string descricaoSubCategoria = "Nova Sub Categoria";
            SubCategoria subcategoria = new SubCategoria(id, descricaoSubCategoria, 0);
            Assert.Equal(id, subcategoria.Id);
            Assert.Equal(descricaoSubCategoria, subcategoria.Descricao);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string descricaoSubCategoria = "Nova Sub Categoria";
            SubCategoria subcategoria = new SubCategoria(id, descricaoSubCategoria, 0);
            Assert.NotEqual(id, subcategoria.Id);
            Assert.Equal(descricaoSubCategoria, subcategoria.Descricao);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string descricaoSubCategoria = string.Empty;
            Assert.Throws<ArgumentException>(() => new SubCategoria(id, descricaoSubCategoria, 0));
        }
    }
}