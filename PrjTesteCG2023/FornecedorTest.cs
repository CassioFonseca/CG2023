
using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class FornecedorTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            FornecedorController fornecedorController = new FornecedorController();
            int id = 0;
            string nomeFornecedor = String.Format("Novo Fornecedor {0}", Guid.NewGuid().ToString().Substring(0, 5));
            int idNewFornecedor = fornecedorController.Adicionar(nomeFornecedor);
            Fornecedor? fornecedor = fornecedorController.GetId(idNewFornecedor);
            Assert.NotNull(fornecedor);
            Assert.NotEqual(id, fornecedor.Id);
            Assert.Equal(nomeFornecedor, fornecedor.Nome);
        }
    }
}