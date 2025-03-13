using System;
using System.Globalization;
using Altitude.Classes;

namespace Altitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double contador = 0; int registro = 0, apoio = 0;

                Console.WriteLine("Vamos decolar!!\nDigite qualquer tecla para iniciar o voa");
                Console.ReadKey();
                Console.Clear();
                while (contador == 0)
                {
                    Console.WriteLine("Estamos decolando!!");
                    Random VooVariavel = new Random();
                    registro = VooVariavel.Next(apoio, apoio+400);
                    apoio = registro;
                    Console.WriteLine($"Altitude atual: {registro}M/S");
                    Task.Delay(3000).Wait();
                    Console.Clear();
                    if (registro >= 3048.0)
                    {
                        contador++;
                    }
                }
                CalAltitude Aviao = new CalAltitude(registro);
                while (contador == 1)
                {
                    Console.WriteLine("Nova altitude: ");
                    Random VooVariavel = new Random();
                    int novo_registro = VooVariavel.Next(apoio-40, apoio+20);
                    Aviao.Distance(novo_registro);
                    Aviao.MensagemDeAviso();
                    Console.WriteLine(Aviao.ToString());
                    Task.Delay(3000).Wait();
                    Console.Clear();
                    if (novo_registro <= 0)
                    {
                        Console.WriteLine("O Avião pousou");
                        contador++;
                    }
                }
            }
        }
    }
}