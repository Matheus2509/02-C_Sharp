using System.Globalization;
using System.Collections.Generic;
namespace Por.Classes
{
    abstract internal class Impostos
    {
        public string Nome { get; set; }
        public double Renda { get; set; }

        public Impostos(double renda, string nome)
        {
            Nome = nome;
            Renda = renda;
        }
        public abstract double CalImposto();

        public override string ToString()
        {
            return $"{Nome}: R${CalImposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
