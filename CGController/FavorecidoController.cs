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
        public Favorecido CriarFavorecido(string nome)
        {
            return favorecidoUC.Criar(nome);
        }
        public Favorecido? GetFavorecidoId(int id)
        {
            return favorecidoUC.GetId(id);

        }
        public Favorecido? GetFirst()
        {
            return favorecidoUC.GetFirst();

        }

    }
}