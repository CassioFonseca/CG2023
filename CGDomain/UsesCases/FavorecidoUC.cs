using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class FavorecidoUC
    {
        public FavorecidoUC() { }
        public static int Add(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException($"'{nameof(nome)}' cannot be null or whitespace.", nameof(nome));
            }

            Favorecido favorecido = New(nome);
            Add(favorecido);
            return favorecido.Id;
        }
        public static void Add(Favorecido favorecido)
        {
            FavorecidoRepository favorecidoRepository = new();
            favorecidoRepository.Add(favorecido.DbSetFavorecido);
            favorecidoRepository.Salve();
        }
        public static Favorecido New(string nome)
        {
            return new Favorecido(nome);
        }
        public static Favorecido New(DbSetFavorecido dbSetFavorecido)
        {
            return new Favorecido(dbSetFavorecido);
        }
        public static void Change(Favorecido favorecido)
        {
            FavorecidoRepository favorecidoRepository = new();
            favorecidoRepository.Update(favorecido.DbSetFavorecido);
        }
        public static void Remove(Favorecido favorecido)
        {
            FavorecidoRepository favorecidoRepository = new();
            favorecidoRepository.Remove(favorecido.DbSetFavorecido);
        }
        public static Favorecido? GetId(int id)
        {
            FavorecidoRepository favorecidoRepository = new();
            DbSetFavorecido? dbSetFavorecido = favorecidoRepository.GetId(id);
            if (dbSetFavorecido == null) return null;
            Favorecido favorecido = New(dbSetFavorecido);
            return favorecido;
        }
        public static Favorecido? First
        {
            get
            {
                FavorecidoRepository favorecidoRepository = new();
                DbSetFavorecido? dbSetFavorecido = favorecidoRepository.GetFirst();
                if (dbSetFavorecido == null) return null;
                Favorecido favorecido = New(dbSetFavorecido);
                return favorecido;
            }
        }
        public static List<Favorecido>? GetAll
        {
            get
            {
                FavorecidoRepository favorecidoRepository = new();
                List<DbSetFavorecido> dbSetFavorecidos = favorecidoRepository.GetAll();
                if (dbSetFavorecidos == null) return null;
                List<Favorecido> favorecidos = new();
                foreach (DbSetFavorecido dbSetFavorecido in dbSetFavorecidos)
                    favorecidos.Add(New(dbSetFavorecido));
                return favorecidos;
            }
        }
    }
}
