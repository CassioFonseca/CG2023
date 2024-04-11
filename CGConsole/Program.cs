using CGController;
using CGEntity.Entities;
using CGServer.Repository;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace CGConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
            MontaMenuPrincipal();
        }

        private static void MontaMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1 - Categorias");
            Console.WriteLine("2 - Favorecido");
            Console.WriteLine("0 - Sair");
            _ = int.TryParse(Console.ReadLine(), out int result);
            switch (result)
            {
                case 0:
                    string[] args = new string[1];
                    Main(args);
                    break;
                case 1:
                    MontaMenuCategoria.ShowMenu();
                    break;
            }
        }

       /* private static void AdicionarCategoria()
        {

            CategoriaController categoriaController = new CategoriaController();
            int idNewCategoria = CategoriaController.Add(String.Format("Teste Adiciona Categoria {0}", Guid.NewGuid().ToString().Substring(0, 5)));
            Console.WriteLine(string.Format("Id do nova categoria {0}", idNewCategoria));
        }
        private static void GetCategoria()
        {
            CategoriaController categoriaController = new CategoriaController();
            Categoria? categoria = CategoriaController.GetId(5);
            if (categoria is not null)
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
            Favorecido? favorecido = favorecidoController.GetFavorecidoId(5);
            if (favorecido is not null)
                Console.WriteLine(string.Format("Nome novo favorecido {0} - {1}", favorecido.Id, favorecido.Nome));
        } */
    }
};