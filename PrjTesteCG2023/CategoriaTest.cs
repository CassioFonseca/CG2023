using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class CategoriaTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string descricaoCategoria = String.Format("Nova Categoria {0}", Guid.NewGuid().ToString()[..5]);
            int idNewCategoria = CategoriaController.Add(descricaoCategoria);
            Categoria? categoria = CategoriaController.GetId(idNewCategoria);
            Assert.NotNull(categoria);
            Assert.NotEqual(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }
    }
}