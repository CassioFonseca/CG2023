using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class SubCategoriaController
    {
        public static int Add(int idCategoria, string dsSubCategoria) => SubCategoriaUC.Add(idCategoria, dsSubCategoria);
        public static SubCategoria New(int idCategoria, string dsSubCategoria) => SubCategoriaUC.New(idCategoria, dsSubCategoria);
        public static SubCategoria? GetId(int id) => SubCategoriaUC.GetId(id);
        public static SubCategoria? GetFirst => SubCategoriaUC.First;
        public static SubCategoria? GetFirstCategoria(int idCategoria) => SubCategoriaUC.GetFirstCategoria(idCategoria);
        public static List<SubCategoria>? GetAll() => SubCategoriaUC.GetAll;
        public static void Change(SubCategoria categoria) => SubCategoriaUC.Change(categoria);
        public static void Remove(SubCategoria categoria) => SubCategoriaUC.Remove(categoria);
    }
}
