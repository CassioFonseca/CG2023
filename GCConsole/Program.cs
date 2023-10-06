using CGEntity.Entities;

namespace GCConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Diretório Local da Aplicação: " + diretorioAtual);

            /*try
            {
                Favorecido newFavorecido = new(1, "João");
                Console.WriteLine(newFavorecido.Id);
                Console.WriteLine(newFavorecido.Nome);
                Console.ReadLine();
                newFavorecido.Nome = "Cássio";
                Console.WriteLine(newFavorecido.Nome);
                Console.ReadLine();
                newFavorecido.Nome = string.Empty;
                Console.WriteLine(newFavorecido.Nome);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               // throw;
            }*/
            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}