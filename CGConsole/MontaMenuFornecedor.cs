using CGController;
using CGEntity.Entities;

namespace CGConsole
{
    internal class MontaMenuFornecedor
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Fornecedor");
            Console.WriteLine("1 - Adicionar Fornecedor");
            Console.WriteLine("2 - Listar Fornecedores");
            Console.WriteLine("3 - Alterar Fornecedor");
            Console.WriteLine("4 - Excluir Fornecedor");
            Console.WriteLine("0 - Retornar");
            Console.Write("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddFornecedor();
                    break;
                case 2:
                    GetAllFornecedores();
                    break;
                case 3:
                    ChangeFornecedor();
                    break;
                case 4:
                    RemoveFornecedor();
                    break;
            }
        }

        private static void AddFornecedor()
        {
            Console.Write("Digite um nome para o fornecedor: ");
            string? nmFornecedor = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nmFornecedor))
                Console.WriteLine("Nome invalido!");
            else
            {
                int idNewFornecedor = FornecedorController.Add(nmFornecedor);
                Fornecedor? fornecedor = GetFornecedorId(idNewFornecedor);
                if (fornecedor == null)
                    Console.WriteLine("Erro ao adicionar fornecedor!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static Fornecedor? GetFornecedorId(int id)
        {
            return FornecedorController.GetId(id);
        }
        private static void GetAllFornecedores()
        {
            Console.Clear();
            Console.WriteLine("Listando Fornecedoress: ");
            List<Fornecedor>? fornecedores = FornecedorController.GetAll();
            if (fornecedores == null)
                Console.WriteLine("Não existem fornecedores!!");
            else
            {
                foreach (Fornecedor fornecedor in fornecedores)
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
                Console.WriteLine(string.Format("Total de fornecedores {0}", fornecedores.Count));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void ChangeFornecedor()
        {
            Console.Clear();
            Console.WriteLine("Alterar Fornecedor");
            Console.Write("Digite o id do fornecedor a ser alterado: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Fornecedor? fornecedor = GetFornecedorId(id);
            if (fornecedor == null)
                Console.WriteLine("Fornecedor não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
                Console.Write("Novo nome: ");
                fornecedor.Nome = Console.ReadLine() ?? string.Empty;
                FornecedorController.Change(fornecedor);
                fornecedor = GetFornecedorId(fornecedor.Id);
                if (fornecedor == null)
                    Console.WriteLine("Fornecedor não existe!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void RemoveFornecedor()
        {
            Console.Clear();
            Console.WriteLine("Excluir Fornecedor");
            Console.Write("Digite o id do fornecedor a ser excluido: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Fornecedor? fornecedor = GetFornecedorId(id);
            if (fornecedor == null)
                Console.WriteLine("Fornecedor não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
                Console.Write("Confirma exclusão(s/n)?");
                string confirma = Console.ReadLine() ?? string.Empty;
                if (confirma == "s")
                {
                    FornecedorController.Remove(fornecedor);
                    fornecedor = GetFornecedorId(fornecedor.Id);
                    if (fornecedor == null)
                        Console.WriteLine("Fornecedor removido!");
                    else
                        Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
                }
            }
            Console.ReadLine();
            ShowMenu();
        }
    }
}
