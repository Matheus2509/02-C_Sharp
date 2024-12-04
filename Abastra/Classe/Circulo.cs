using Abastra.Classe.Enum;
using System.Globalization;
using System.Collections.Generic;

namespace Abastra.Classe
{
    sealed internal class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(Color cor,string tipo, double raio) : base(cor, tipo)
        {
            Raio = raio * raio;
        }

        public override double Area()
        {
            return Math.PI * Raio;
        }

    }
}
