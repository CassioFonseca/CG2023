using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class FavorecidoUC
    {
        public FavorecidoUC()
        {

        }

        public int AdicionarFavorecido(string nome) 
        {
            Favorecido favorecido = CriarFavorecido(nome);
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            favorecidoRepository.Adicionar(favorecido.DbSetFavorecido);
            SalvarFavorecido(favorecidoRepository);
            return favorecido.Id;
        }

        public Favorecido CriarFavorecido(string nome)
        {
            return new Favorecido(nome);
        }
        public Favorecido CriarFavorecido(DbSetFavorecido dbSetFavorecido)
        {
            return new Favorecido(dbSetFavorecido);
        }

        private void SalvarFavorecido(FavorecidoRepository favorecidoRepository) 
        {
            favorecidoRepository.Salvar();
        }

        public Favorecido GetFavorecidoId(int id) 
        {
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            DbSetFavorecido dbSetFavorecido = favorecidoRepository.GetId(id);
            Favorecido favorecido = CriarFavorecido(dbSetFavorecido);
            return favorecido;
        }
    }
}
