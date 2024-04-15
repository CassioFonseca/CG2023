using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class FornecedorController
    {
        public static int Add(string nome) => FornecedorUC.Add(nome);
        public static Fornecedor New(string nome) => FornecedorUC.New(nome);
        public static Fornecedor? GetId(int id) => FornecedorUC.GetId(id);
        public static Fornecedor? GetFirst => FornecedorUC.First;
        public static List<Fornecedor>? GetAll() => FornecedorUC.GetAll;
        public static void Change(Fornecedor favorecido) => FornecedorUC.Change(favorecido);
        public static void Remove(Fornecedor favorecido) => FornecedorUC.Remove(favorecido);
    }
}
