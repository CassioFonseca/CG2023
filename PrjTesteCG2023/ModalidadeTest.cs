using CGEntity.Entities;

namespace CGTeste


{
    public class ModalidadeTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string descricaoModalidade = "Nova Modalidade";
            Modalidade modalidade = new Modalidade(id, descricaoModalidade);
            Assert.Equal(id, modalidade.Id);
            Assert.Equal(descricaoModalidade, modalidade.Descricao);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string descricaoModalidade = "Nova Modalidade";
            Modalidade modalidade = new Modalidade(id, descricaoModalidade);
            Assert.NotEqual(id, modalidade.Id);
            Assert.Equal(descricaoModalidade, modalidade.Descricao);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string descricaoModalidade = string.Empty;
            Assert.Throws<ArgumentException>(() => new Modalidade(id, descricaoModalidade));
        }
    }
}