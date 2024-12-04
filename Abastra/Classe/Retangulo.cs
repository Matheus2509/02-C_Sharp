using Abastra.Classe.Enum;
using System.Globalization;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Abastra.Classe
{
    sealed internal class Retangulo : Forma
    {
        public double Altura { get; set; }
        public double Lado { get; set; }

        public Retangulo(Color cor, string tipo, double altura, double lado) : base(cor, tipo)
        {
            Altura = altura;
            Lado = lado;
        }

        public override double Area()
        {
            return Altura * Lado;
        }
    }
}
