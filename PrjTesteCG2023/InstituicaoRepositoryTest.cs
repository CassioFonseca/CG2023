using CGServer.Repository;

namespace CGTeste


{
    public class InstituicaoRepositoryTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 1;
            string nomeInstituicao = "Nova Insituicao";
            InstituicaoRepository instituicao = new InstituicaoRepository(id, nomeInstituicao);
            Assert.Equal(id, instituicao.Id);
            Assert.Equal(nomeInstituicao, instituicao.Nome);
        }

        [Fact]
        public void TestCreateClass2()
        {
            int id = 0;
            string nomeInstituicao = "Nova Insituicao";
            InstituicaoRepository instituicao = new InstituicaoRepository(id, nomeInstituicao);
            Assert.NotEqual(id, instituicao.Id);
            Assert.Equal(nomeInstituicao, instituicao.Nome);
        }

        [Fact]
        public void TestCreateClassExcecao()
        {
            int id = 1;
            string nomeInstituicao = string.Empty;
            Assert.Throws<ArgumentException>(() => new InstituicaoRepository(id, nomeInstituicao));
        }
    }
}