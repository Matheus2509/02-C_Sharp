using System.Globalization;
namespace Projeto_Copilot
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Por favor, enviar a informações do seu carro: ");
                Console.Write("Ano de lançamento:");
                int ano = int.Parse(Console.ReadLine());
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Marca: ");
                string marca = Console.ReadLine();

                Carros test = new Carros(marca, modelo, ano);

                Console.WriteLine(test.ToString());
            }
        }
}