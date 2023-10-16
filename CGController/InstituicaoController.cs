using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class InstituicaoController
    {
        private InstituicaoUC InstituicaoUC;
        public InstituicaoController()
        {
            this.InstituicaoUC = new InstituicaoUC();
        }
        public int Adicionar(string nome)
        {
            return InstituicaoUC.Adicionar(nome);
        }
        public Instituicao Criar(string nome)
        {
            return InstituicaoUC.Criar(nome);
        }
        public Instituicao? GetId(int id)
        {
            return InstituicaoUC.GetId(id);

        }
        public Instituicao? GetFirst()
        {
            return InstituicaoUC.GetFirst();

        }
    }
}
