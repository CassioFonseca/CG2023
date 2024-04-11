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
    internal class MontaMenuCategoria
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(" Menu Categorias");
            Console.WriteLine("1 - Adicionar Categoria");
            Console.WriteLine("2 - Listar Categorias");
            Console.WriteLine("3 - Alterar Categoria");
            Console.WriteLine("4 - Excluir Categoria");
            Console.WriteLine("0 - Retornar");
            Console.WriteLine("Digite uma opção acima:");
            string? entrada = Console.ReadLine();
            _ = int.TryParse(entrada, out int result);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    AddCategoria();
                    break;
                case 2:
                    GetAllCategorias();
                    break;
                case 3:
                    //AlterarCategoria();
                    break;
                case 4:
                    //ExcluirCategoria();
                    break;
            }
        }

        private static void AddCategoria()
        {
            Console.WriteLine("Digite uma descrição para a categoria: ");
            string? dsCategoria = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(dsCategoria))
            {
                Console.WriteLine("Categoria invalida!");
                return;
            }
            int idNewCategoria = CategoriaController.Add(dsCategoria);
            Categoria? categoria = GetCategoriaId(idNewCategoria);
            if (categoria == null)
            {
                Console.WriteLine("Erro ao adicionar categoria!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine(categoria.Id);
            Console.WriteLine(categoria.Descricao);
            Console.ReadLine();
        }
        private static Categoria? GetCategoriaId(int id)
        {
            return CategoriaController.GetId(id);
        }
        private static void GetAllCategorias()
        {
            Console.Clear();
            Console.WriteLine("Listando Categorias: ");
            List<Categoria>? Categorias = CategoriaController.GetAll();
            if (Categorias == null)
            {
                Console.WriteLine("Não existem categorias!!");
                return;
            }
            foreach (Categoria categoria in Categorias)
            {
                Console.WriteLine(String.Format("Id: {0} - Descrição {1}", categoria.Id, categoria.Descricao));
            }
            Console.WriteLine(string.Format("Total de categorias {0}",Categorias.Count));
            Console.ReadLine();
        }
    }
}
