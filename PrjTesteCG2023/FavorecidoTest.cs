
using CGController;
using CGEntity.Entities;

namespace CGTeste
{
    public class FavorecidoTest
    {
        [Fact]
        public void TestCreateClass1()
        {
            int id = 0;
            string nomeFavorecido = string.Format("NovoFavorecido {0}", Guid.NewGuid().ToString()[..5]);
            int idNewFavorecido = FavorecidoController.Add(nomeFavorecido);
            Favorecido? favorecido = FavorecidoController.GetId(idNewFavorecido);
            Assert.NotNull(favorecido);
            Assert.NotEqual(id, favorecido.Id);
            Assert.Equal(nomeFavorecido, favorecido.Nome);
        }
    }
}