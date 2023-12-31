using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class SubCategoriaTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            SubCategoriaController subCategoriaController = new SubCategoriaController();
            int id = 0;
            string descricaoSubCategoria = String.Format("Nova SubCategoria {0}", Guid.NewGuid().ToString().Substring(0, 5));
            CategoriaController categoriaController = new CategoriaController();
            Categoria? categoria = categoriaController.GetFirst();
            Assert.NotNull(categoria);
            int idNewSubCategoria = subCategoriaController.Adicionar(categoria.Id, descricaoSubCategoria);
            SubCategoria? subCategoria = subCategoriaController.GetId(idNewSubCategoria);
            Assert.NotNull(subCategoria);
            Assert.NotEqual(id, subCategoria.Id);
            Assert.Equal(descricaoSubCategoria, subCategoria.Descricao);
        }
    }
}