using Abastra.Classe.Enum;
using Abastra.Classe;
using System.Globalization;
using System.Collections.Generic;
namespace Abastra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Forma> Form = new List<Forma>();
            Console.Write("Quantas formas: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Circulo ou Retangulo?");
                string tipo = Console.ReadLine();
                Console.WriteLine("Cor da forma: \nBLACK\nBLUE\nRED");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if (tipo == "Circulo")
                {
                    Console.Write("Raio do circulo: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Form.Add(new Circulo(cor, tipo, raio));
                }
                else
                {
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado: ");
                    double lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Form.Add(new Retangulo(cor, tipo, altura, lado));
                }
                
            }
            Console.Clear();
            foreach (Forma forma in Form)
            {
                Console.WriteLine($"{forma}\n---------------");
            }
        }
    }
}
