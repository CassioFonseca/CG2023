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
            MontaMenuPrincipal();
        }

        private static void MontaMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1 - Categorias");
            Console.WriteLine("2 - Favorecido");
            Console.WriteLine("3 - Fornecedor");
            Console.WriteLine("4 - Instituição");
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
                case 2:
                    MontaMenuFavorecido.ShowMenu();
                    break;
                case 3:
                    MontaMenuFornecedor.ShowMenu();
                    break;
                case 4:
                    MontaMenuInstituicao.ShowMenu();
                    break;
            }
        }
    }
};