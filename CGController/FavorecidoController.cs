using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class FavorecidoController
    {
        private FavorecidoUC favorecidoUC;
        public FavorecidoController() => this.favorecidoUC = new FavorecidoUC();
        public int AdicionarFavorecido(string nome) => favorecidoUC.AdicionarFavorecido(nome);
        public Favorecido CriarFavorecido(string nome) => favorecidoUC.Criar(nome);
        public Favorecido? GetFavorecidoId(int id) => favorecidoUC.GetId(id);
        public Favorecido? First => favorecidoUC.GetFirst();

    }
}