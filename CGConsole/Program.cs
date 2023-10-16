using CGController;
using CGEntity.Entities;
using CGServer.Repository;
using System.Runtime.CompilerServices;

namespace CGConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //AdicionarCategoria();
            //Console.ReadLine();
            //AdicionarFavorecido();
            GetFavorecido();
            Console.ReadLine();
        }

        private static void AdicionarCategoria()
        {

            CategoriaController categoriaController = new CategoriaController();
            int idNewCategoria = categoriaController.Adicionar(String.Format("Teste Adiciona Categoria {0}", Guid.NewGuid().ToString().Substring(0, 5)));
            Console.WriteLine(string.Format("Id do nova categoria {0}", idNewCategoria));
        }
        private static void GetCategoria()
        {
            CategoriaController categoriaController = new CategoriaController();
            Categoria categoria = categoriaController.GetId(5);
            Console.WriteLine(string.Format("Nome nova categoria {0} - {1}", categoria.Id, categoria.Descricao));
        }
        private static void AdicionarFavorecido()
        {
            FavorecidoController favorecidoController = new FavorecidoController();
            int idNewFavorecido = favorecidoController.AdicionarFavorecido(String.Format("Teste Adiciona Favorecido {0}",Guid.NewGuid().ToString().Substring(0,5)));
            Console.WriteLine(string.Format("Id do novo favorecido {0}",idNewFavorecido));
        }

        private static void GetFavorecido()
        {
            FavorecidoController favorecidoController = new FavorecidoController();
            Favorecido favorecido = favorecidoController.GetFavorecidoId(5);
            Console.WriteLine(string.Format("Nome novo favorecido {0} - {1}", favorecido.Id, favorecido.Nome));
        }
    }
}