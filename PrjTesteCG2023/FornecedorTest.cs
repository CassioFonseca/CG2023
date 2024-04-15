
using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class FornecedorTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string nomeFornecedor = String.Format("Novo Fornecedor {0}", Guid.NewGuid().ToString()[..5]);
            int idNewFornecedor = FornecedorController.Add(nomeFornecedor);
            Fornecedor? fornecedor = FornecedorController.GetId(idNewFornecedor);
            Assert.NotNull(fornecedor);
            Assert.NotEqual(id, fornecedor.Id);
            Assert.Equal(nomeFornecedor, fornecedor.Nome);
        }
    }
}