using CGDomain.UsesCases;
using CGEntity.Entities;


namespace CGController
{
    public class FornecedorController
    {
        private FornecedorUC fornecedorUC;
        public FornecedorController()
        {
            this.fornecedorUC = new FornecedorUC();
        }
        public int Adicionar(string nome)
        {
            return fornecedorUC.Adicionar(nome);
        }
        public Fornecedor Criar(string nome)
        {
            return fornecedorUC.Criar(nome);
        }
        public Fornecedor? GetId(int id)
        {
            return fornecedorUC.GetId(id);
        }
        public Fornecedor? GetFirst()
        {
            return fornecedorUC.GetFirst();
        }
    }
}
