
using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class FavorecidoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            FavorecidoController favorecidoController = new FavorecidoController();
            int id = 0;
            string nomeFavorecido = String.Format("NovoFavorecido {0}", Guid.NewGuid().ToString().Substring(0, 5));
            int idNewFavorecido = favorecidoController.AdicionarFavorecido(nomeFavorecido);
            Favorecido? favorecido = favorecidoController.GetFavorecidoId(idNewFavorecido);
            Assert.NotNull(favorecido);
            Assert.NotEqual(id, favorecido.Id);
            Assert.Equal(nomeFavorecido, favorecido.Nome);
        }
    }
}