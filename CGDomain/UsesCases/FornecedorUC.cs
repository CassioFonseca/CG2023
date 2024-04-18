using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class FornecedorUC
    {
        public FornecedorUC() { }
        private static FornecedorRepository Repository
        {
            get { return new(); }
        }
        public static int Add(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException($"'{nameof(nome)}' cannot be null or whitespace.", nameof(nome));
            }

            Fornecedor fornecedor = New(nome);
            Add(fornecedor);
            return fornecedor.Id;
        }
        public static void Add(Fornecedor fornecedor)
        {
            FornecedorRepository repository = Repository;
            repository.Add(fornecedor.DbSetFornecedor);
            repository.Salve();
        }
        public static Fornecedor New(string nome)
        {
            return new Fornecedor(nome);
        }
        public static Fornecedor New(DbSetFornecedor dbSetFornecedor)
        {
            return new Fornecedor(dbSetFornecedor);
        }
        public static void Change(Fornecedor fornecedor)
        {
            Repository.Update(fornecedor.DbSetFornecedor);
        }
        public static void Remove(Fornecedor fornecedor)
        {
            Repository.Remove(fornecedor.DbSetFornecedor);
        }
        public static Fornecedor? GetId(int id)
        {
            DbSetFornecedor? dbSetFornecedor = Repository.GetId(id);
            if (dbSetFornecedor == null) return null;
            Fornecedor fornecedor = New(dbSetFornecedor);
            return fornecedor;
        }
        public static Fornecedor? First
        {
            get
            {
                DbSetFornecedor? dbSetFornecedor = Repository.GetFirst();
                if (dbSetFornecedor == null) return null;
                Fornecedor fornecedor = New(dbSetFornecedor);
                return fornecedor;
            }
        }
        public static List<Fornecedor>? GetAll
        {
            get
            {
                List<DbSetFornecedor> dbSetFornecedores = Repository.GetAll();
                if (dbSetFornecedores == null) return null;
                List<Fornecedor> fornecedores = new();
                foreach (DbSetFornecedor dbSetFornecedor in dbSetFornecedores)
                    fornecedores.Add(New(dbSetFornecedor));
                return fornecedores;
            }
        }
    }
}
