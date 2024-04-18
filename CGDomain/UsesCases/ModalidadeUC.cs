using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class ModalidadeUC
    {
        public ModalidadeUC() { }
        private static ModalidadeRepository Repository
        {
            get { return new(); }
        }
        public static int Add(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException($"'{nameof(descricao)}' cannot be null or whitespace.", nameof(descricao));
            }

            Modalidade categoria = New(descricao);
            Add(categoria);
            return categoria.Id;
        }
        public static void Add(Modalidade modalidade)
        {
            ModalidadeRepository repository = Repository;
            repository.Add(modalidade.DbSetModalidade);
            repository.Salve();
        }
        public static Modalidade New(string descricao)
        {
            return new Modalidade(descricao);
        }
        public static Modalidade New(DbSetModalidade dbSetModalidade)
        {
            return new Modalidade(dbSetModalidade);
        }
        public static void Change(Modalidade modalidade)
        {
            Repository.Update(modalidade.DbSetModalidade);
        }
        public static void Remove(Modalidade modalidade)
        {
            Repository.Remove(modalidade.DbSetModalidade);
        }
        public static Modalidade? GetId(int id)
        {
            DbSetModalidade? dbSetModalidade = Repository.GetId(id);
            if (dbSetModalidade == null) return null;
            Modalidade modalidade = New(dbSetModalidade);
            return modalidade;
        }
        public static Modalidade? First
        {
            get
            {
                DbSetModalidade? dbSetModalidade = Repository.GetFirst();
                if (dbSetModalidade == null) return null;
                Modalidade modalidade = New(dbSetModalidade);
                return modalidade;
            }
        }
        public static List<Modalidade>? GetAll
        {
            get
            {
                List<DbSetModalidade> dbSetModalidades = Repository.GetAll();
                if (dbSetModalidades == null) return null;
                List<Modalidade> modalidades = new();
                foreach (DbSetModalidade dbSetModalidade in dbSetModalidades)
                    modalidades.Add(New(dbSetModalidade));
                return modalidades;
            }
        }
    }
}
