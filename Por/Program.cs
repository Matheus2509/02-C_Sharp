using System.Globalization;
using System.Collections.Generic;
using Por.Classes;

namespace Por
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double Total = 0;
            List<Impostos>Gov = new List<Impostos>();
            Console.WriteLine("Quantidades de pessoas");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("J ou F");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (p == 'j' || p =='J')
                {
                    Console.Write("Quantidades de trabalahdores: ");
                    int pessoas = int.Parse(Console.ReadLine());
                    Gov.Add(new Juritica(renda, nome, pessoas));
                }
                else {
                    Console.Write("Gasto com saude: ");
                    double saude = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Gov.Add(new Fisica(renda, nome, saude));
                }
            }
            Console.Clear();
            foreach(Impostos impostos in Gov)
            {
                Console.WriteLine(impostos);
                Total += impostos.CalImposto();
            }
            Console.WriteLine($"Total arrecadado {Total.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
