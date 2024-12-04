using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace test.Classes
{
    sealed internal class Terceirizado : Funcionarios
    {
        public double Adicional { get; set; }

        public Terceirizado(string nome, int horas, double valorHoras, double adicional) : base(nome, horas, valorHoras)
        {
            Adicional = CalculoPorc(adicional);
        }
        public double CalculoPorc(double adicional)
        {
            double Total = adicional * 0.10;
            Total += adicional;
            return Total;
        }
        public sealed override double Contrato()
        {
            double Total = base.Contrato();
            Total += Adicional;
            return Total;
        }

    }
}
