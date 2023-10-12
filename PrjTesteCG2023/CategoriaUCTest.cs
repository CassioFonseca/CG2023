using CGDomain.UsesCases;
using CGEntity.Entities;
using CGEntity.EntitiesDbSet;

namespace CGTeste


{
    public class CategoriaUCTest
    {
        [Fact]
        public void CriarCategoriaValida()
        {
            int id = 1;
            string dsNovaCategoria = string.Format("Nova categoria {0}", Guid.NewGuid().GetHashCode());
            CategoriaUC categoriaUC = new CategoriaUC();
            Categoria categoria = categoriaUC.CriarCategoria(id, dsNovaCategoria);
            Assert.Equal(id, categoria.Id);
            Assert.Equal(dsNovaCategoria, categoria.Descricao);
        }
        
        [Fact]
        public void CriarCategoriaIdInvalido()
        {
            int id = 0;
            string descricaoCategoria = string.Format("Nova categoria {0}", new DateTime());
            CategoriaUC categoriaUC = new CategoriaUC();
            Categoria categoria = categoriaUC.CriarCategoria(id, descricaoCategoria);
            Assert.NotEqual(id, categoria.Id);
            Assert.Equal(descricaoCategoria, categoria.Descricao);
        }
        [Fact]
        public void CriarCategoriaDescricaoInvalida()
        {
            int id = 1;
            string descricaoCategoria = string.Empty;
            CategoriaUC categoriaUC = new CategoriaUC();
            Assert.Throws<ArgumentException>(() => categoriaUC.CriarCategoria(id, descricaoCategoria));
        }
        [Fact]
        public void AdicionaCategoria()
        { 
            int id = 0;
            string descricaoCategoria = string.Format("Nova categoria adicionada {0}", new DateTime());
            CategoriaUC categoriaUC = new CategoriaUC();
            int idNovaCategoria = categoriaUC.AdicionarCategoria(id, descricaoCategoria);
            Assert.NotEqual(id, idNovaCategoria);
        }
    }
}