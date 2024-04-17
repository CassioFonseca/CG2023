using CGController;
using CGEntity.Entities;

namespace CGConsole
{
    internal class MontaMenuPagador
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Pagadores");
            Console.WriteLine("1 - Adicionar Pagador");
            Console.WriteLine("2 - Listar Pagadores");
            Console.WriteLine("3 - Alterar Pagador");
            Console.WriteLine("4 - Excluir Pagador");
            Console.WriteLine("0 - Retornar");
            Console.Write("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddPagador();
                    break;
                case 2:
                    GetAllPagadores();
                    break;
                case 3:
                    ChangePagador();
                    break;
                case 4:
                    RemovePagador();
                    break;
            }
        }

        private static void AddPagador()
        {
            Console.Write("Digite um nome para o pagador: ");
            string? nmPagador = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nmPagador))
                Console.WriteLine("Pagador inválido!");
            else
            {
                int idNewPagador = PagadorController.Add(nmPagador);
                Pagador? pagador = GetPagadorId(idNewPagador);
                if (pagador == null)
                    Console.WriteLine("Erro ao adicionar pagador!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", pagador.Id, pagador.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static Pagador? GetPagadorId(int id)
        {
            return PagadorController.GetId(id);
        }
        private static void GetAllPagadores()
        {
            Console.Clear();
            Console.WriteLine("Listando Pagadores: ");
            List<Pagador>? pagadores = PagadorController.GetAll();
            if (pagadores == null)
                Console.WriteLine("Não existem pagadores!!");
            else
            {
                foreach (Pagador pagador in pagadores)
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", pagador.Id, pagador.Nome));
                Console.WriteLine(string.Format("Total de pagadores {0}", pagadores.Count));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void ChangePagador()
        {
            Console.Clear();
            Console.WriteLine("Alterar Pagador");
            Console.Write("Digite o id do pagador a ser alterado: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Pagador? pagador = GetPagadorId(id);
            if (pagador == null)
                Console.WriteLine("Pagador não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", pagador.Id, pagador.Nome));
                Console.Write("Novo nome: ");
                pagador.Nome = Console.ReadLine() ?? string.Empty;
                PagadorController.Change(pagador);
                pagador = GetPagadorId(pagador.Id);
                if (pagador == null)
                    Console.WriteLine("Pagador não existe!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", pagador.Id, pagador.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void RemovePagador()
        {
            Console.Clear();
            Console.WriteLine("Excluir Pagador");
            Console.Write("Digite o id do pagador a ser excluido: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Pagador? pagador = GetPagadorId(id);
            if (pagador == null)
                Console.WriteLine("Pagador não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", pagador.Id, pagador.Nome));
                Console.Write("Confirma exclusão(s/n)?");
                string confirma = Console.ReadLine() ?? string.Empty;
                if (confirma == "s")
                {
                    PagadorController.Remove(pagador);
                    pagador = GetPagadorId(pagador.Id);
                    if (pagador == null)
                        Console.WriteLine("Pagador removido!");
                    else
                        Console.WriteLine(String.Format("Id: {0} - Pagador {1}", pagador.Id, pagador.Nome));
                }
            }
            Console.ReadLine();
            ShowMenu();
        }
    }
}
