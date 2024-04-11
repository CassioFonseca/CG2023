using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class ModalidadeUC
    {
        public ModalidadeUC() { }
        public int Adicionar(string value)
        {
            Modalidade modalidade = Criar(value);
            ModalidadeRepository modalidadeRepository = new ModalidadeRepository();
            modalidadeRepository.Add(modalidade.DbSetModalidade);
            Salvar(modalidadeRepository);
            return modalidade.Id;
        }
        public Modalidade Criar(string value)
        {
            return new Modalidade(value);
        }
        public Modalidade Criar(DbSetModalidade dbSetModalidade)
        {
            return new Modalidade(dbSetModalidade);
        }
        private void Salvar(ModalidadeRepository modalidadeRepository)
        {
            modalidadeRepository.Salve();
        }
        public Modalidade? GetId(int id)
        {
            ModalidadeRepository modalidadeRepository = new ModalidadeRepository();
            DbSetModalidade? dbSetModalidade = modalidadeRepository.GetId(id);
            if (dbSetModalidade == null) return null;
            Modalidade modalidade = Criar(dbSetModalidade);
            return modalidade;
        }
        public Modalidade? GetFirst()
        {
            ModalidadeRepository modalidadeRepository = new ModalidadeRepository();
            DbSetModalidade? dbSetModalidade = modalidadeRepository.GetFirst();
            if (dbSetModalidade == null) return null;
            Modalidade modalidade = Criar(dbSetModalidade);
            return modalidade;
        }
    }
}
