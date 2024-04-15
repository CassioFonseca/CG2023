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
    internal class MontaMenuModalidade
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Modalidades");
            Console.WriteLine("1 - Adicionar Modalidade");
            Console.WriteLine("2 - Listar Modalidades");
            Console.WriteLine("3 - Alterar Modalidade");
            Console.WriteLine("4 - Excluir Modalidade");
            Console.WriteLine("0 - Retornar");
            Console.Write("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddModalidade();
                    break;
                case 2:
                    GetAllModalidades();
                    break;
                case 3:
                    ChangeModalidade();
                    break;
                case 4:
                    RemoveModalidade();
                    break;
            }
        }

        private static void AddModalidade()
        {
            Console.Write("Digite uma descrição para a modalidade: ");
            string? dsModalidade = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(dsModalidade))
                Console.WriteLine("Modalidade invalida!");
            else
            {
                int idNewModalidade = ModalidadeController.Add(dsModalidade);
                Modalidade? modalidade = GetModalidadeId(idNewModalidade);
                if (modalidade == null)
                    Console.WriteLine("Erro ao adicionar modalidade!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", modalidade.Id, modalidade.Descricao));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static Modalidade? GetModalidadeId(int id)
        {
            return ModalidadeController.GetId(id);
        }
        private static void GetAllModalidades()
        {
            Console.Clear();
            Console.WriteLine("Listando Modalidades: ");
            List<Modalidade>? modalidades = ModalidadeController.GetAll();
            if (modalidades == null)
                Console.WriteLine("Não existem modalidades!!");
            else
            {
                foreach (Modalidade modalidade in modalidades)
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", modalidade.Id, modalidade.Descricao));
                Console.WriteLine(string.Format("Total de categorias {0}", modalidades.Count));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void ChangeModalidade()
        {
            Console.Clear();
            Console.WriteLine("Alterar Modalidade");
            Console.Write("Digite o id da modalidade a ser alterada: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Modalidade? modalidade = GetModalidadeId(id);
            if (modalidade == null)
                Console.WriteLine("Modalidade não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Descrição {1}", modalidade.Id, modalidade.Descricao));
                Console.Write("Nova descrição: ");
                modalidade.Descricao = Console.ReadLine() ?? string.Empty;
                ModalidadeController.Change(modalidade);
                modalidade = GetModalidadeId(modalidade.Id);
                if (modalidade == null)
                    Console.WriteLine("Categoria não existe!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", modalidade.Id, modalidade.Descricao));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void RemoveModalidade()
        {
            Console.Clear();
            Console.WriteLine("Excluir Modalidade");
            Console.Write("Digite o id da modalidade a ser excluida: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            Modalidade? modalidade = GetModalidadeId(id);
            if (modalidade == null)
                Console.WriteLine("Modalidade não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Descrição {1}", modalidade.Id, modalidade.Descricao));
                Console.Write("Confirma exclusão(s/n)?");
                string confirma = Console.ReadLine() ?? string.Empty;
                if (confirma == "s")
                {
                    ModalidadeController.Remove(modalidade);
                    modalidade = GetModalidadeId(modalidade.Id);
                    if (modalidade == null)
                        Console.WriteLine("Modalidade removida!");
                    else
                        Console.WriteLine(String.Format("Id: {0} - Descrição {1}", modalidade.Id, modalidade.Descricao));
                }
            }
            Console.ReadLine();
            ShowMenu();
        }
    }
}
