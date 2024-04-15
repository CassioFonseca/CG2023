using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;


namespace CGDomain.UsesCases
{
    public class FornecedorUC
    {
        public FornecedorUC() { }
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
            FornecedorRepository fornecedorRepository = new();
            fornecedorRepository.Add(fornecedor.DbSetFornecedor);
            fornecedorRepository.Salve();
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
            FornecedorRepository fornecedorRepository = new();
            fornecedorRepository.Update(fornecedor.DbSetFornecedor);
        }
        public static void Remove(Fornecedor fornecedor)
        {
            FornecedorRepository fornecedorRepository = new();
            fornecedorRepository.Remove(fornecedor.DbSetFornecedor);
        }
        public static Fornecedor? GetId(int id)
        {
            FornecedorRepository fornecedorRepository = new();
            DbSetFornecedor? dbSetFornecedor = fornecedorRepository.GetId(id);
            if (dbSetFornecedor == null) return null;
            Fornecedor fornecedor = New(dbSetFornecedor);
            return fornecedor;
        }
        public static Fornecedor? First
        {
            get
            {
                FornecedorRepository fornecedorRepository = new();
                DbSetFornecedor? dbSetFornecedor = fornecedorRepository.GetFirst();
                if (dbSetFornecedor == null) return null;
                Fornecedor fornecedor = New(dbSetFornecedor);
                return fornecedor;
            }
        }
        public static List<Fornecedor>? GetAll
        {
            get
            {
                FornecedorRepository fornecedorRepository = new();
                List<DbSetFornecedor> dbSetFornecedores = fornecedorRepository.GetAll();
                if (dbSetFornecedores == null) return null;
                List<Fornecedor> fornecedores = new();
                foreach (DbSetFornecedor dbSetFornecedor in dbSetFornecedores)
                    fornecedores.Add(New(dbSetFornecedor));
                return fornecedores;
            }
        }
    }
}
