using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class ModalidadeTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            ModalidadeController modalidadeController = new ModalidadeController();
            int id = 0;
            string nomeModalidade = String.Format("Nova Modalidade {0}", Guid.NewGuid().ToString().Substring(0, 5));
            int idNewModalidade = modalidadeController.Adicionar(nomeModalidade);
            Modalidade? modalidade = modalidadeController.GetId(idNewModalidade);
            Assert.NotNull(modalidade);
            Assert.NotEqual(id, modalidade.Id);
            Assert.Equal(nomeModalidade, modalidade.Nome);
        }
    }
}