using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class InstituicaoUC
    {
        public InstituicaoUC() { }
        public int Adicionar(string value)
        {
            Instituicao instituicao = Criar(value);
            InstituicaoRepository instituicaoRepository = new InstituicaoRepository();
            instituicaoRepository.AdicionarDbSet(instituicao.DbSetInstituicao);
            Salvar(instituicaoRepository);
            return instituicao.Id;
        }
        public Instituicao Criar(string value)
        {
            return new Instituicao(value);
        }
        public Instituicao Criar(DbSetInstituicao dbSetInstituicao)
        {
            return new Instituicao(dbSetInstituicao);
        }
        private void Salvar(InstituicaoRepository instituicaoRepository)
        {
            instituicaoRepository.Salvar();
        }

        public Instituicao? GetId(int id)
        {
            InstituicaoRepository instituicaoRepository = new InstituicaoRepository();
            DbSetInstituicao? dbSetInstituicao = instituicaoRepository.DbSetGetId(id);
            if (dbSetInstituicao == null) return null;
            Instituicao instituicao = Criar(dbSetInstituicao);
            return instituicao;
        }
        public Instituicao? GetFirst()
        {
            InstituicaoRepository instituicaoRepository = new InstituicaoRepository();
            DbSetInstituicao? dbSetInstituicao = instituicaoRepository.DbSetGetFirst();
            if (dbSetInstituicao == null) return null;
            Instituicao instituicao = Criar(dbSetInstituicao);
            return instituicao;
        }
    }
}