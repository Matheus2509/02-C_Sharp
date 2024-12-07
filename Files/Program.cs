using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Local = @"C:\Users\mathe\OneDrive\Área de Trabalho\Projetos novos\02-C_Sharp\file1.txt";
            string Criar = @"C:\Users\mathe\OneDrive\Área de Trabalho\Projetos novos\02-C_Sharp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(Local);
                fileInfo.CopyTo(Criar);
                string[] line = File.ReadAllLines(Local);

                foreach (string line2 in line) {
                    Console.WriteLine(line2);                
                
                }

            }
            catch (IOException e) {
                Console.WriteLine("Erro encontrado" + e.Message);
            }
        }
    }
}
