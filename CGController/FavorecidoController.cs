using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class FavorecidoController
    {
        private FavorecidoUC favorecidoUC;
        public FavorecidoController()
        {
            this.favorecidoUC = new FavorecidoUC();
        }
        public int AdicionarFavorecido(string nome)
        {
            return favorecidoUC.AdicionarFavorecido(nome);
        }
        public Favorecido CriarCategoria(string nome)
        {
            return favorecidoUC.CriarFavorecido(nome);
        }
        public Favorecido GetFavorecidoId(int id)
        {
            return favorecidoUC.GetFavorecidoId(id);

        }

    }
}