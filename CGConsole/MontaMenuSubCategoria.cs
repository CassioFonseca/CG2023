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
    internal class MontaMenuSubCategoria
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Sub-Categorias");
            Console.WriteLine("1 - Adicionar SubCategoria");
            Console.WriteLine("2 - Listar SubCategorias");
            Console.WriteLine("3 - Alterar SubCategoria");
            Console.WriteLine("4 - Excluir SubCategoria");
            Console.WriteLine("0 - Retornar");
            Console.Write("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddSubCategoria();
                    break;
                case 2:
                    GetAllSubCategorias();
                    break;
                case 3:
                    ChangeSubCategoria();
                    break;
                case 4:
                    RemoveSubCategoria();
                    break;
            }
        }

        private static void AddSubCategoria()
        {
            Console.Write("Digite o id da categoria: ");
            if (!int.TryParse(Console.ReadLine(), out int idCategoria))
            {
                Console.ReadLine();
                ShowMenu();
            }            
            Console.ReadLine();
            Console.Write("Digite uma descrição para a subcategoria: ");
            string? dsCategoria = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(dsCategoria))
                Console.WriteLine("SubCategoria invalida!");
            else
            {
                int idNewSubCategoria = SubCategoriaController.Add(idCategoria, dsCategoria);
                SubCategoria? subCategoria = GetSubCategoriaId(idNewSubCategoria);
                if (subCategoria == null)
                    Console.WriteLine("Erro ao adicionar subcategoria!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", subCategoria.Id, subCategoria.Descricao));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static SubCategoria? GetSubCategoriaId(int id)
        {
            return SubCategoriaController.GetId(id);
        }
        private static void GetAllSubCategorias()
        {
            Console.Clear();
            Console.WriteLine("Listando SubCategorias: ");
            List<SubCategoria>? subCategorias = SubCategoriaController.GetAll();
            if (subCategorias == null)
                Console.WriteLine("Não existem subcategorias!!");
            else
            {
                foreach (SubCategoria subCategoria in subCategorias)
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", subCategoria.Id, subCategoria.Descricao));
                Console.WriteLine(string.Format("Total de categorias {0}", subCategorias.Count));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void ChangeSubCategoria()
        {
            Console.Clear();
            Console.WriteLine("Alterar SubCategoria");
            Console.Write("Digite o id da subcatetoria a ser alterada: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            SubCategoria? subCategoria = GetSubCategoriaId(id);
            if (subCategoria == null)
                Console.WriteLine("Subcategoria não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Descrição {1}", subCategoria.Id, subCategoria.Descricao));
                Console.Write("Nova descrição: ");
                subCategoria.Descricao = Console.ReadLine() ?? string.Empty;
                SubCategoriaController.Change(subCategoria);
                subCategoria = GetSubCategoriaId(subCategoria.Id);
                if (subCategoria == null)
                    Console.WriteLine("Subcategoria não existe!");
                else
                    Console.WriteLine(String.Format("Id: {0} - Descrição {1}", subCategoria.Id, subCategoria.Descricao));
            }
            Console.ReadLine();
            ShowMenu();
        }
        private static void RemoveSubCategoria()
        {
            Console.Clear();
            Console.WriteLine("Excluir SubCategoria");
            Console.Write("Digite o id da subcatetoria a ser excluida: ");
            _ = int.TryParse(Console.ReadLine(), out var id);
            SubCategoria? subcategoria = GetSubCategoriaId(id);
            if (subcategoria == null)
                Console.WriteLine("Subcategoria não existe!");
            else
            {
                Console.WriteLine(String.Format("Id: {0} - Descrição {1}", subcategoria.Id, subcategoria.Descricao));
                Console.Write("Confirma exclusão(s/n)?");
                string confirma = Console.ReadLine() ?? string.Empty;
                if (confirma == "s")
                {
                    SubCategoriaController.Remove(subcategoria);
                    subcategoria = GetSubCategoriaId(subcategoria.Id);
                    if (subcategoria == null)
                        Console.WriteLine("SubCategoria removida!");
                    else
                        Console.WriteLine(String.Format("Id: {0} - Descrição {1}", subcategoria.Id, subcategoria.Descricao));
                }
            }
            Console.ReadLine();
            ShowMenu();
        }
    }
}
