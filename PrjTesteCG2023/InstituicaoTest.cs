using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class InstituicaoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string nomeInstituicao = String.Format("Nova Insitutuicao {0}", Guid.NewGuid().ToString()[..5]);
            int idNewInstituicao = InstituicaoController.Add(nomeInstituicao);
            Instituicao? instituicao = InstituicaoController.GetId(idNewInstituicao);
            Assert.NotNull(instituicao);
            Assert.NotEqual(id, instituicao.Id);
            Assert.Equal(nomeInstituicao, instituicao.Nome);
        }
    }
}