using CGDomain.UsesCases;
using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGController
{
    public class PagadorController
    {
        public static int Add(string nome) => PagadorUC.Add(nome);
        public static Pagador New(string nome) => PagadorUC.New(nome);
        public static Pagador? GetId(int id) => PagadorUC.GetId(id);
        public static Pagador? GetFirst => PagadorUC.First;
        public static List<Pagador>? GetAll() => PagadorUC.GetAll;
        public static void Change(Pagador pagador) => PagadorUC.Change(pagador);
        public static void Remove(Pagador pagador) => PagadorUC.Remove(pagador);
    }
}