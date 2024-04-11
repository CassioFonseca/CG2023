using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CGDomain.UsesCases
{
    public class CategoriaUC
    {
        public CategoriaUC() { }
        public static int Add(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException($"'{nameof(descricao)}' cannot be null or whitespace.", nameof(descricao));
            }

            Categoria categoria = New(descricao);
            Add(categoria);
            return categoria.Id;
        }
        public static void Add(Categoria categoria)
        {
            CategoriaRepository categoriaRepository = new();
            categoriaRepository.Add(categoria.DbSetCategoria);
            categoriaRepository.Salve();
        }
        public static Categoria New(string descricao)
        {
            return new Categoria(descricao);
        }
        public static Categoria New(DbSetCategoria dbSetCategoria)
        {
            return new Categoria(dbSetCategoria);
        }
        public static void Change(Categoria categoria)
        {
            CategoriaRepository categoriaRepository = new();
            categoriaRepository.Update(categoria.DbSetCategoria);
        }
        public static void Remove(Categoria categoria)
        {
            CategoriaRepository categoriaRepository = new();
            categoriaRepository.Remove(categoria.DbSetCategoria);
        }

        public static Categoria? GetId(int id)
        {
            CategoriaRepository categoriaRepository = new();
            DbSetCategoria? dbSetCategoria = categoriaRepository.GetId(id);
            if (dbSetCategoria == null) return null;
            Categoria categoria = New(dbSetCategoria);
            return categoria;
        }
        public static Categoria? First
        {
            get
            {
                CategoriaRepository categoriaRepository = new();
                DbSetCategoria? dbSetCategoria = categoriaRepository.GetFirst();
                if (dbSetCategoria == null) return null;
                Categoria categoria = New(dbSetCategoria);
                return categoria;
            }
        }
        public static List<Categoria>? GetAll
        {
            get
            {
                CategoriaRepository categoriaRepository = new();
                List<DbSetCategoria> dbSetCategorias = categoriaRepository.GetAll();
                if (dbSetCategorias == null) return null;
                List<Categoria> categorias = new();
                foreach (DbSetCategoria dbSetCategoria in dbSetCategorias)
                    categorias.Add(New(dbSetCategoria));
                return categorias;
            }
        }
    }
}
