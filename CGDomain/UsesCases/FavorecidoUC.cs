using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class FavorecidoUC
    {
        public FavorecidoUC() { }
        private static FavorecidoRepository Repository
        {
            get { return new(); }
        }
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
            FavorecidoRepository repository = Repository;
            repository.Add(favorecido.DbSetFavorecido);
            repository.Salve();
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
            Repository.Update(favorecido.DbSetFavorecido);
        }
        public static void Remove(Favorecido favorecido)
        {
            Repository.Remove(favorecido.DbSetFavorecido);
        }
        public static Favorecido? GetId(int id)
        {
            DbSetFavorecido? dbSetFavorecido = Repository.GetId(id);
            if (dbSetFavorecido == null) return null;
            Favorecido favorecido = New(dbSetFavorecido);
            return favorecido;
        }
        public static Favorecido? First
        {
            get
            {
                DbSetFavorecido? dbSetFavorecido = Repository.GetFirst();
                if (dbSetFavorecido == null) return null;
                Favorecido favorecido = New(dbSetFavorecido);
                return favorecido;
            }
        }
        public static List<Favorecido>? GetAll
        {
            get
            {
                List<DbSetFavorecido> dbSetFavorecidos = Repository.GetAll();
                if (dbSetFavorecidos == null) return null;
                List<Favorecido> favorecidos = new();
                foreach (DbSetFavorecido dbSetFavorecido in dbSetFavorecidos)
                    favorecidos.Add(New(dbSetFavorecido));
                return favorecidos;
            }
        }
    }
}
