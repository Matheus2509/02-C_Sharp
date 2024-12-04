using System.Globalization;
namespace Conta
{
    internal class Program
    {
        static void Main(string[] args) {

            Banco Conta;
            int apoio = 0;

            Console.WriteLine("Bem vindo, você está no banco MJM !!!");
            Console.Write("Digite seu nome para criar uma conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número pra conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Desejar depositar? [S/N]:");
            char r1 = char.Parse(Console.ReadLine());
            if (r1 == 'S' || r1 == 's')
            {
                Console.Write("Insira o deposito: ");
                double saldo = double.Parse(Console.ReadLine());
                Conta = new Banco(numero, nome, saldo);
            }
            else {
                Conta = new Banco(numero, nome);
            }
            Console.Clear();
            Console.WriteLine(Conta);

            while (apoio == 0)
            {
                Console.WriteLine("Deseja adicionar ou retirar algum valor?[S/N]:");
                char r2 = char.Parse(Console.ReadLine());
                if (r2 == 'S' || r2 == 's')
                {
                    Console.WriteLine("Por favor escolher uma das opções");
                    Console.WriteLine("1-Retirar\n2-Depositar");
                    int r3 = int.Parse(Console.ReadLine());
                    if (r3 == 1)
                    {
                        Console.Write("Digite o valor que vai ser retirado: ");
                        double retirar = double.Parse(Console.ReadLine());
                        Conta.Subtração(retirar);
                        Console.Clear();
                        Console.WriteLine(Conta);
                    }
                    else if (r3 == 2)
                    {
                        Console.Write("Digite o valor que vai ser depositado: ");
                        double deposito = double.Parse(Console.ReadLine());
                        Conta.Adição(deposito);
                        Console.Clear();
                        Console.WriteLine(Conta);
                    }

                }
                else
                {
                    Console.WriteLine("Obrigado pela preferencia tenha um ótimo dia");
                    apoio = 1;
                }
            }
        }          
    }
    
}