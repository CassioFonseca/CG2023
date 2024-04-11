using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class CategoriaController
    {
        public static int Add(string descricao)
        {
            return CategoriaUC.Add(descricao);
        }
        public static Categoria New(string descricao)
        {
            return CategoriaUC.New(descricao);
        }
        public static Categoria? GetId(int id)
        {
            return CategoriaUC.GetId(id);
        }
        public static Categoria? GetFirst()
        {
            return CategoriaUC.First;
        }
        public static List<Categoria>? GetAll()
        {
            return CategoriaUC.GetAll;
        }
        public static void Change(Categoria categoria)
        {
            CategoriaUC.Change(categoria);
        }
        public static void Remove(Categoria categoria)
        {
            CategoriaUC.Remove(categoria);
        }
    }
}