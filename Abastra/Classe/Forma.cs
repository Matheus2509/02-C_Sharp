using Abastra.Classe.Enum;
using System.Globalization;
using System.Collections.Generic;

namespace Abastra.Classe
{
    abstract internal class Forma
    {
        public Color Cor { get; set; }
        public string Tipo { get; set; }

        public Forma(Color cor, string tipo)
        {
            Tipo = tipo;
            Cor = cor;
        }

        public abstract double Area();

        public override string ToString()
        {
            return $"Formato: {Tipo} Cor: {Cor}, área: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

}
