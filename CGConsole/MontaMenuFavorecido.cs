using CGController;
using CGEntity.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGConsole
{
    internal class MontaMenuFavorecido
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Favorecidos");
            Console.WriteLine("1 - Adicionar Favorecido");
            Console.WriteLine("2 - Listar Favorecidos");
            Console.WriteLine("3 - Alterar Favorecido");
            Console.WriteLine("4 - Excluir FAvorecido");
            Console.WriteLine("0 - Retornar");
            Console.Write("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddFavorecido();
                    break;
                case 2:
                    GetAllFavorecidos();
                    break;
                case 3:
                    ChangeFavorecido();
                    break;
                case 4:
                    RemoveFavorecido();
                    break;
            }
        }

        private static void AddFavorecido()
        {
            Console.Write("Digite uma descrição para o favorecido: ");
            string? nmFavorecido = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nmFavorecido))
                Console.WriteLine("Descrição invalida!");
            else
            {
                int idNewFavorecido = FavorecidoController.Add(nmFavorecido);
                Favorecido? favorecido = GetFavorecidoId(idNewFavorecido);
                if (favorecido == null)
                    Console.WriteLine("Erro ao adicionar favorecido!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", favorecido.Id, favorecido.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static Favorecido? GetFavorecidoId(int id)
        {
            return FavorecidoController.GetId(id);
        }
        private static void GetAllFavorecidos()
        {
            Console.Clear();
            Console.WriteLine("Listando Favorecidos: ");
            List<Favorecido>? favorecidos = FavorecidoController.GetAll();
            if (favorecidos == null)
                Console.WriteLine("Não existem categorias!!");
            else
            {
                foreach (Favorecido favorecido in favorecidos)
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", favorecido.Id, favorecido.Nome));
                Console.WriteLine(string.Format("Total de favorecidos {0}", favorecidos.Count));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void ChangeFavorecido()
        {
            Console.Clear();
            Console.WriteLine("Alterar Favorecido");
            Console.Write("Digite o id do favorecido a ser alterado: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Favorecido? favorecido = GetFavorecidoId(id);
            if (favorecido == null)
                Console.WriteLine("Favorecido não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", favorecido.Id, favorecido.Nome));
                Console.Write("Nova descrição: ");
                favorecido.Nome = Console.ReadLine() ?? string.Empty;
                FavorecidoController.Change(favorecido);
                favorecido = GetFavorecidoId(favorecido.Id);
                if (favorecido == null)
                    Console.WriteLine("Favorecido não existe!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", favorecido.Id, favorecido.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void RemoveFavorecido()
        {
            Console.Clear();
            Console.WriteLine("Excluir Favorecido");
            Console.Write("Digite o id do favorecido a ser excluido: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Favorecido? favorecido = GetFavorecidoId(id);
            if (favorecido == null)
                Console.WriteLine("Favorecido não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", favorecido.Id, favorecido.Nome));
                Console.Write("Confirma exclusão(s/n)?");
                string confirma = Console.ReadLine() ?? string.Empty;
                if (confirma == "s")
                {
                    FavorecidoController.Remove(favorecido);
                    favorecido = GetFavorecidoId(favorecido.Id);
                    if (favorecido == null)
                        Console.WriteLine("Favorecido removida!");
                    else
                        Console.WriteLine(String.Format("Id: {0} - Nome {1}", favorecido.Id, favorecido.Nome));
                }
            }
            Console.ReadLine();
            ShowMenu();
        }
    }
}
