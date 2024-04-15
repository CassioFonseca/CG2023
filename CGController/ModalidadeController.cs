using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class ModalidadeController
    {
        public static int Add(string descricao)
        {
            return ModalidadeUC.Add(descricao);
        }
        public static Modalidade New(string descricao)
        {
            return ModalidadeUC.New(descricao);
        }
        public static Modalidade? GetId(int id)
        {
            return ModalidadeUC.GetId(id);
        }
        public static Modalidade? GetFirst()
        {
            return ModalidadeUC.First;
        }
        public static List<Modalidade>? GetAll()
        {
            return ModalidadeUC.GetAll;
        }
        public static void Change(Modalidade modalidade)
        {
            ModalidadeUC.Change(modalidade);
        }
        public static void Remove(Modalidade modalidade)
        {
            ModalidadeUC.Remove(modalidade);
        }
    }
}