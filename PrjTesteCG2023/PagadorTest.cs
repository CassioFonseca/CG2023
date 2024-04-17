using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class PagadorTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string descricaoPagador = String.Format("Novo Pagador {0}", Guid.NewGuid().ToString()[..5]);
            int idNewPagador = PagadorController.Add(descricaoPagador);
            Pagador? pagador = PagadorController.GetId(idNewPagador);
            Assert.NotNull(pagador);
            Assert.NotEqual(id, pagador.Id);
            Assert.Equal(descricaoPagador, pagador.Nome);
        }
    }
}