using System.Collections.Generic;
using System.Globalization;
using test.Classes;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Funcionarios> Trabalhadores = new List<Funcionarios>();
            Console.WriteLine("Olá, bem vindo a MEL\nEsse programa calcula a salário dos funcionarios");
            Console.Write("Por farvo, digite a quantidade de funcionarios: ");
            int quantidadeDeTrabalhadores = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeDeTrabalhadores; i++)
            {
                Console.WriteLine($"Funcionario #{i + 1}");
                Console.WriteLine("O funcionario é tercerizado? [S/N]");
                char tipoFucionario = char.Parse(Console.ReadLine());
                Console.Write("Nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade de horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor da hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipoFucionario == 's' || tipoFucionario == 'S')
                {
                    Console.Write("Valor adicional da despeça: ");
                    double adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Trabalhadores.Add(new Terceirizado(nome, horas, valorHora, adicional));
                }
                else
                {
                    Trabalhadores.Add(new Funcionarios(nome, horas, valorHora));
                }  
            }
            Console.Clear();
            Console.WriteLine("Pagamento: ");
            foreach (var tr in Trabalhadores)
            {
                Console.WriteLine($"{tr}\n--------------------- ");
            }
        }

    }
}
