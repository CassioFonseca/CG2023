using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class SubCategoriaTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string descricaoSubCategoria = String.Format("Nova SubCategoria {0}", Guid.NewGuid().ToString()[..5]);
            Categoria? categoria = CategoriaController.GetFirst;
            Assert.NotNull(categoria);
            int idNewSubCategoria = SubCategoriaController.Add(categoria.Id, descricaoSubCategoria);
            SubCategoria? subCategoria = SubCategoriaController.GetId(idNewSubCategoria);
            Assert.NotNull(subCategoria);
            Assert.NotEqual(id, subCategoria.Id);
            Assert.Equal(descricaoSubCategoria, subCategoria.Descricao);
        }
    }
}