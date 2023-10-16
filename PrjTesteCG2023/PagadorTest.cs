using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class PagadorTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            PagadorController pagadorController = new PagadorController();
            int id = 0;
            string descricaoPagador = String.Format("Novo Pagador {0}", Guid.NewGuid().ToString().Substring(0, 5));
            int idNewPagador = pagadorController.Adicionar(descricaoPagador);
            Pagador? pagador = pagadorController.GetId(idNewPagador);
            Assert.NotNull(pagador);
            Assert.NotEqual(id, pagador.Id);
            Assert.Equal(descricaoPagador, pagador.Descricao);
        }
    }
}