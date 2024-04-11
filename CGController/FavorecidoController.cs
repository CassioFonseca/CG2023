using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class FavorecidoController
    {
        public static int Add(string nome) => FavorecidoUC.Add(nome);
        public static Favorecido New(string nome) => FavorecidoUC.New(nome);
        public static Favorecido? GetId(int id) => FavorecidoUC.GetId(id);
        public static Favorecido? GetFirst => FavorecidoUC.First;
        public static List<Favorecido>? GetAll() => FavorecidoUC.GetAll;
        public static void Change(Favorecido favorecido) => FavorecidoUC.Change(favorecido);
        public static void Remove(Favorecido favorecido) => FavorecidoUC.Remove(favorecido);
    }
}