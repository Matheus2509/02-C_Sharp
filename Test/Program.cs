using System.Globalization;
using System.Collections.Generic;
using Test.Classe;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listProdutos = new List<Produto>();
            Console.Write("Comprinhas!!!\nQuantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Qual vai ser o tipo da compra: \n-Exportado\n-Usado\n-Novo ");
                string tipo = Console.ReadLine();
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == "Usado")
                {
                    Console.Write("Data de fabricação");
                    DateTime fabricação = DateTime.Parse(Console.ReadLine());
                    listProdutos.Add(new Usados(nome, preço, fabricação));
                }
                else if(tipo == "Exportado")
                {
                    Console.Write("Taxa de exportação: ");
                    double taxa  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProdutos.Add(new Exportados(nome, preço, taxa));
                }
                else
                {
                    listProdutos.Add(new Produto(nome, preço));
                }
                
            }
            Console.Clear();
            foreach (var item in listProdutos)
            {
                Console.WriteLine($"{item}\n----------------");
            }
        }
    }
}
