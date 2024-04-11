using CGDomain.UsesCases;
using CGEntity.Entities;

namespace CGController
{
    public class CategoriaController
    {
        public static int Add(string descricao)
        {
            return CategoriaUC.Adicionar(descricao);
        }
        public static Categoria New(string descricao)
        {
            return CategoriaUC.Criar(descricao);
        }
        public static Categoria? GetId(int id)
        {
            return CategoriaUC.GetId(id);

        }
        public static Categoria? GetFirst()
        {
            return CategoriaUC.First;
        }
        public static List<Categoria>? GetAll()
        {
            return CategoriaUC.GetAll;
        }
    }
}