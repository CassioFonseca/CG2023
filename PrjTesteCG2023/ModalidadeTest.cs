using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class ModalidadeTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string dsModalidade = String.Format("Nova Modalidade {0}", Guid.NewGuid().ToString()[..5]);
            int idNewModalidade = ModalidadeController.Add(dsModalidade);
            Modalidade? modalidade = ModalidadeController.GetId(idNewModalidade);
            Assert.NotNull(modalidade);
            Assert.NotEqual(id, modalidade.Id);
            Assert.Equal(dsModalidade, modalidade.Descricao);
        }
    }
}