using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class InstituicaoController
    {
        public static int Add(string nome) => InstituicaoUC.Add(nome);
        public static Instituicao New(string nome) => InstituicaoUC.New(nome);
        public static Instituicao? GetId(int id) => InstituicaoUC.GetId(id);
        public static Instituicao? GetFirst => InstituicaoUC.First;
        public static List<Instituicao>? GetAll() => InstituicaoUC.GetAll;
        public static void Change(Instituicao instituicao) => InstituicaoUC.Change(instituicao);
        public static void Remove(Instituicao instituicao) => InstituicaoUC.Remove(instituicao);
    }
}
