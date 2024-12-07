using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Local = @"C:\Users\mathe\OneDrive\Área de Trabalho\Projetos novos\02-C_Sharp\file1.txt";
            string Criar = @"C:\Users\mathe\OneDrive\Área de Trabalho\Projetos novos\02-C_Sharp\file2.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(Local);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException x)
            {
                Console.WriteLine("Erro; " + x.Message);
            }
            finally {
                if (sr != null) sr.Close();
            }
         }

    }
}

