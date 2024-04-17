using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class ModalidadeController
    {
        public static int Add(string descricao) => ModalidadeUC.Add(descricao);
        public static Modalidade New(string descricao) => ModalidadeUC.New(descricao);
        public static Modalidade? GetId(int id) => ModalidadeUC.GetId(id);
        public static Modalidade? GetFirst => ModalidadeUC.First;
        public static List<Modalidade>? GetAll() => ModalidadeUC.GetAll;
        public static void Change(Modalidade modalidade) => ModalidadeUC.Change(modalidade);
        public static void Remove(Modalidade modalidade) => ModalidadeUC.Remove(modalidade);
    }
}