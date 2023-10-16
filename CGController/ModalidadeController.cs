using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class ModalidadeController
    {
        private ModalidadeUC ModalidadeUC;
        public ModalidadeController()
        {
            this.ModalidadeUC = new ModalidadeUC();
        }
        public int Adicionar(string nome)
        {
            return ModalidadeUC.Adicionar(nome);
        }
        public Modalidade Criar(string nome)
        {
            return ModalidadeUC.Criar(nome);
        }
        public Modalidade? GetId(int id)
        {
            return ModalidadeUC.GetId(id);

        }
        public Modalidade? GetFirst()
        {
            return ModalidadeUC.GetFirst();

        }
    }
}