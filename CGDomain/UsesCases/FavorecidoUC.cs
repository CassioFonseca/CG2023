using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class FavorecidoUC
    {
        public FavorecidoUC() { }

        public int AdicionarFavorecido(string nome) 
        {
            Favorecido favorecido = Criar(nome);
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            favorecidoRepository.Add(favorecido.DbSetFavorecido);
            Salvar(favorecidoRepository);
            return favorecido.Id;
        }

        public Favorecido Criar(string nome)
        {
            return new Favorecido(nome);
        }
        public Favorecido Criar(DbSetFavorecido dbSetFavorecido)
        {
            return new Favorecido(dbSetFavorecido);
        }

        private void Salvar(FavorecidoRepository favorecidoRepository) 
        {
            favorecidoRepository.Salve();
        }

        public Favorecido? GetId(int id) 
        {
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            DbSetFavorecido? dbSetFavorecido = favorecidoRepository.GetId(id);
            if (dbSetFavorecido == null) return null;
            Favorecido favorecido = Criar(dbSetFavorecido);
            return favorecido;
        }
        public Favorecido? GetFirst()
        {
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            DbSetFavorecido? dbSetFavorecido = favorecidoRepository.GetFirst();
            if (dbSetFavorecido == null) return null;
            Favorecido favorecido = Criar(dbSetFavorecido);
            return favorecido;
        }
    }
}
