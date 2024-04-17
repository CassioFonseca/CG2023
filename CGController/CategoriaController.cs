using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class CategoriaController
    {
        public static int Add(string nome) => CategoriaUC.Add(nome);
        public static Categoria New(string nome) => CategoriaUC.New(nome);
        public static Categoria? GetId(int id) => CategoriaUC.GetId(id);
        public static Categoria? GetFirst => CategoriaUC.First;
        public static List<Categoria>? GetAll() => CategoriaUC.GetAll;
        public static void Change(Categoria categoria) => CategoriaUC.Change(categoria);
        public static void Remove(Categoria categoria) => CategoriaUC.Remove(categoria);
    }
}