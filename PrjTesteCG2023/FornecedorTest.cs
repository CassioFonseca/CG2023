using CGEntity.Entities;

namespace CGTeste


{
    public class FornecedorTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string nomeFornecedor = "Novo Fornecedor";
            Fornecedor fornecedor = new Fornecedor(id, nomeFornecedor);
            Assert.Equal(id, fornecedor.Id);
            Assert.Equal(nomeFornecedor, fornecedor.Nome);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string nomeFornecedor = "Novo Fornecedor";
            Fornecedor fornecedor = new Fornecedor(id, nomeFornecedor);
            Assert.NotEqual(id, fornecedor.Id);
            Assert.Equal(nomeFornecedor, fornecedor.Nome);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string nomeFornecedor = string.Empty;
            Assert.Throws<ArgumentException>(() => new Fornecedor(id, nomeFornecedor));
        }
    }
}