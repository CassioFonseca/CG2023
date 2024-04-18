using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class PagadorUC
    {
        public PagadorUC() { }
        private static PagadorRepository Repository
        {
            get { return new(); }
        }
        public static int Add(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException($"'{nameof(nome)}' cannot be null or whitespace.", nameof(nome));
            }
            Pagador pagador = New(nome);
            Add(pagador);
            return pagador.Id;
        }
        public static void Add(Pagador pagador)
        {
            PagadorRepository repository = Repository;
            repository.Add(pagador.DbSetPagador);
            repository.Salve();
        }
        public static Pagador New(string nome)
        {
            return new Pagador(nome);
        }
        public static Pagador New(DbSetPagador dbSetInstituicao)
        {
            return new Pagador(dbSetInstituicao);
        }
        public static void Change(Pagador pagador)
        {
            Repository.Update(pagador.DbSetPagador);
        }
        public static void Remove(Pagador pagador)
        {
            Repository.Remove(pagador.DbSetPagador);
        }
        public static Pagador? GetId(int id)
        {
            DbSetPagador? dbSetPagador = Repository.GetId(id);
            if (dbSetPagador == null) return null;
            Pagador pagador = New(dbSetPagador);
            return pagador;
        }
        public static Pagador? First
        {
            get
            {
                DbSetPagador? dbSetPagador = Repository.GetFirst();
                if (dbSetPagador == null) return null;
                Pagador pagador = New(dbSetPagador);
                return pagador;
            }
        }
        public static List<Pagador>? GetAll
        {
            get
            {
                PagadorRepository pagadorRepository = Repository;
                List<DbSetPagador> dbSetPagadores = pagadorRepository.GetAll();
                if (dbSetPagadores == null) return null;
                List<Pagador> pagadores = new();
                foreach (DbSetPagador dbSetPagador in dbSetPagadores)
                    pagadores.Add(New(dbSetPagador));
                return pagadores;
            }
        }
    }
}
