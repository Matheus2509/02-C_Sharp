using System.Globalization;
using System.Collections.Generic;

namespace Por.Classes
{
    internal class Fisica : Impostos
    {
        public double Saude { get; set; }

        public Fisica(double renda, string nome,double saude):base(renda, nome) {

            Saude = saude;
        }
        public override double CalImposto()
        {
            double Total;
            if (Renda < 20000.00)
            {
                Total = Renda * 0.15;
                Total -=(Saude*0.50);
            }
            else
            {
                Total = Renda * 0.25;
                Total -= (Saude * 0.50);
            }
            return Total;
        }
    }
}
