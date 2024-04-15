using CGController;
using CGEntity.Entities;

namespace CGConsole
{
    internal class MontaMenuInstituicao

    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Instituição");
            Console.WriteLine("1 - Adicionar Instituição");
            Console.WriteLine("2 - Listar Instituições");
            Console.WriteLine("3 - Alterar Instituição");
            Console.WriteLine("4 - Excluir Instituição");
            Console.WriteLine("0 - Retornar");
            Console.Write("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddInstituicao();
                    break;
                case 2:
                    GetAllInstituicoes();
                    break;
                case 3:
                    ChangeInstituicao();
                    break;
                case 4:
                    RemoveInstituicao();
                    break;
            }
        }

        private static void AddInstituicao()
        {
            Console.Write("Digite um nome para a instituição: ");
            string? nmInstituicao = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nmInstituicao))
                Console.WriteLine("Nome invalido!");
            else
            {
                int idNewInstituicao = InstituicaoController.Add(nmInstituicao);
                Instituicao? instituicao = GetInstituicaoId(idNewInstituicao);
                if (instituicao == null)
                    Console.WriteLine("Erro ao adicionar instituição!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", instituicao.Id, instituicao.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static Instituicao? GetInstituicaoId(int id)
        {
            return InstituicaoController.GetId(id);
        }
        private static void GetAllInstituicoes()
        {
            Console.Clear();
            Console.WriteLine("Listando instituições: ");
            List<Instituicao>? instituicao = InstituicaoController.GetAll();
            if (instituicao == null)
                Console.WriteLine("Não existem instituições!!");
            else
            {
                foreach (Instituicao fornecedor in instituicao)
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", fornecedor.Id, fornecedor.Nome));
                Console.WriteLine(string.Format("Total de instituicões {0}", instituicao.Count));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void ChangeInstituicao()
        {
            Console.Clear();
            Console.WriteLine("Alterar instituição");
            Console.Write("Digite o id da instituição a ser alterada: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Instituicao? instituicao = GetInstituicaoId(id);
            if (instituicao == null)
                Console.WriteLine("Fornecedor não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", instituicao.Id, instituicao.Nome));
                Console.Write("Novo nome: ");
                instituicao.Nome = Console.ReadLine() ?? string.Empty;
                InstituicaoController.Change(instituicao);
                instituicao = GetInstituicaoId(instituicao.Id);
                if (instituicao == null)
                    Console.WriteLine("Instituição não existe!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Nome {1}", instituicao.Id, instituicao.Nome));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void RemoveInstituicao()
        {
            Console.Clear();
            Console.WriteLine("Excluir instituição");
            Console.Write("Digite o id da instituição a ser excluida: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Instituicao? instituicao = GetInstituicaoId(id);
            if (instituicao == null)
                Console.WriteLine("Instituição não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Nome {1}", instituicao.Id, instituicao.Nome));
                Console.Write("Confirma exclusão(s/n)?");
                string confirma = Console.ReadLine() ?? string.Empty;
                if (confirma == "s")
                {
                    InstituicaoController.Remove(instituicao);
                    instituicao = GetInstituicaoId(instituicao.Id);
                    if (instituicao == null)
                        Console.WriteLine("Instituição removida!");
                    else
                        Console.WriteLine(String.Format("Id: {0} - Nome {1}", instituicao.Id, instituicao.Nome));
                }
            }
            Console.ReadLine();
            ShowMenu();
        }
    }
}
