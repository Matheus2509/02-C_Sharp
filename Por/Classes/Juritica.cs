using System.Globalization;
using System.Collections.Generic;

namespace Por.Classes
{
    internal class Juritica : Impostos
    {
        public int Pessoas { get; set; }

        public Juritica(double renda, string nome,int pessoas) :base(renda, nome)
        {
            Pessoas = pessoas;
        }

        public override double CalImposto()
        {
            double Total;
            if (Pessoas >= 10)
            {
                Total = Renda * 0.14;
            }
            else
            {
                Total = Renda * 0.16;
            }
            return Total;
        }
    }
}
