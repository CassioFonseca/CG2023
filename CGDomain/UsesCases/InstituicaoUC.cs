using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class InstituicaoUC
    {
        public InstituicaoUC() { }
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
            InstituicaoRepository instituicaoRepository = new();
            instituicaoRepository.Add(instituicao.DbSetInstituicao);
            instituicaoRepository.Salve();
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
            InstituicaoRepository instituicaoRepository = new();
            instituicaoRepository.Update(instituicao.DbSetInstituicao);
        }
        public static void Remove(Instituicao instituicao)
        {
            InstituicaoRepository instituicaoRepository = new();
            instituicaoRepository.Remove(instituicao.DbSetInstituicao);
        }
        public static Instituicao? GetId(int id)
        {
            InstituicaoRepository instituicaoRepository = new();
            DbSetInstituicao? dbSetInstituicao = instituicaoRepository.GetId(id);
            if (dbSetInstituicao == null) return null;
            Instituicao instituicao = New(dbSetInstituicao);
            return instituicao;
        }
        public static Instituicao? First
        {
            get
            {
                InstituicaoRepository instituicaoRepository = new();
                DbSetInstituicao? dbSetInstituicao = instituicaoRepository.GetFirst();
                if (dbSetInstituicao == null) return null;
                Instituicao instituicao = New(dbSetInstituicao);
                return instituicao;
            }
        }
        public static List<Instituicao>? GetAll
        {
            get
            {
                InstituicaoRepository instituicaoRepository = new();
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