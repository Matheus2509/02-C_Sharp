using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Classes
{
    internal class Funcionarios
    {
        public string Nome { get; private set; }
        public int Horas { get; set; }
        public double ValorHoras { get; set; }

        public Funcionarios(string nome, int horas, double valorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorHoras = valorHoras;
        }

        public virtual double Contrato()
        {
            return ValorHoras * Horas;
        }
        public override string ToString()
        {
            return $"Funciorio: {Nome}\nSalario: R${Contrato().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
