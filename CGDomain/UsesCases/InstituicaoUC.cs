using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class InstituicaoUC
    {
        public InstituicaoUC() { }
        private static InstituicaoRepository Repository
        {
            get{ return new(); }
        }
        public static int Add(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException($"'{nameof(nome)}' cannot be null or whitespace.", nameof(nome));
            }
            Instituicao instituicao = New(nome);
            Add(instituicao);
            return instituicao.Id;
        }
        public static void Add(Instituicao instituicao)
        {
            InstituicaoRepository repository = Repository;
            repository.Add(instituicao.DbSetInstituicao);
            repository.Salve();
        }
        public static Instituicao New(string nome)
        {
            return new Instituicao(nome);
        }
        public static Instituicao New(DbSetInstituicao dbSetInstituicao)
        {
            return new Instituicao(dbSetInstituicao);
        }
        public static void Change(Instituicao instituicao)
        {
            Repository.Update(instituicao.DbSetInstituicao);
        }
        public static void Remove(Instituicao instituicao)
        {
            Repository.Remove(instituicao.DbSetInstituicao);
        }
        public static Instituicao? GetId(int id)
        {
            DbSetInstituicao? dbSetInstituicao = Repository.GetId(id);
            if (dbSetInstituicao == null) return null;
            Instituicao instituicao = New(dbSetInstituicao);
            return instituicao;
        }
        public static Instituicao? First
        {
            get
            {
                DbSetInstituicao? dbSetInstituicao = Repository.GetFirst();
                if (dbSetInstituicao == null) return null;
                Instituicao instituicao = New(dbSetInstituicao);
                return instituicao;
            }
        }
        public static List<Instituicao>? GetAll
        {
            get
            {
                InstituicaoRepository instituicaoRepository = Repository;
                List<DbSetInstituicao> dbSetInstituicoes = instituicaoRepository.GetAll();
                if (dbSetInstituicoes == null) return null;
                List<Instituicao> instituicoes = new();
                foreach (DbSetInstituicao dbSetInstituicao in dbSetInstituicoes)
                    instituicoes.Add(New(dbSetInstituicao));
                return instituicoes;
            }
        }
    }
}