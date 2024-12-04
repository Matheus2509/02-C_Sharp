using Primeios_codigos_c_;
using System.Globalization;

namespace PrimeirosCodigos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produtos p = new Produtos();


            Console.WriteLine("Dados do produto: ");
            Console.Write("Digite o nome do produto: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quant = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produtos: {p}");
            Console.Write($"Digite o número de produtos a ser adicionados:");
            int qte = int.Parse(Console.ReadLine());
            p.Adicionar(qte);
            Console.WriteLine($"Novos dados: {p}");

            Console.Write($"Digite o número de produtos a ser retirado:");
            int qte1 = int.Parse(Console.ReadLine());
            p.Retirar(qte1);
            Console.WriteLine($"Novos dados: {p}");

        }

        
    }
}