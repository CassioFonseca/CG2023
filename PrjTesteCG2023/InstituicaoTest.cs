using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class InstituicaoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            InstituicaoController instituicaoController = new InstituicaoController();
            int id = 0;
            string nomeInstituicao = String.Format("Nova Insitutuicao {0}", Guid.NewGuid().ToString().Substring(0, 5));
            int idNewInstituicao = instituicaoController.Adicionar(nomeInstituicao);
            Instituicao? instituicao = instituicaoController.GetId(idNewInstituicao);
            Assert.NotNull(instituicao);
            Assert.NotEqual(id, instituicao.Id);
            Assert.Equal(nomeInstituicao, instituicao.Nome);
        }
    }
}