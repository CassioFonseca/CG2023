using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class CategoriaTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            CategoriaController categoriaController = new CategoriaController();
            int id = 0;
            string descricaoCategoria = String.Format("Nova Categoria {0}", Guid.NewGuid().ToString().Substring(0, 5));
            int idNewCategoria = categoriaController.Adicionar(descricaoCategoria);
            Categoria? categoria = categoriaController.GetId(idNewCategoria);
            Assert.NotNull(categoria);
            Assert.NotEqual(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }
    }
}