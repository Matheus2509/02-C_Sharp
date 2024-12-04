using System.Globalization;
namespace Aula

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int apoio = 0;
            while (apoio < 1)
            {
                apoio++;
                try
                {
                    Console.Write("Entre na conta: \nId da conta: ");
                    string id = Console.ReadLine();
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Saldo: ");
                    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Limite do dia: ");
                    double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Digite o saque: ");
                    double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Conta Cliente = new Conta(nome, id, saldo, limite);
                    Cliente.Saque(saque);

                }
                catch (Exceção ex)
                {
                    Console.WriteLine("Erro encontrado: " + ex.Message);
                    apoio--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Verifique os dados preencidos estão de acordo com o que foi solicidado");
                    apoio--;
                }
                Console.WriteLine("---------------------");

            }
        }
    }
}
