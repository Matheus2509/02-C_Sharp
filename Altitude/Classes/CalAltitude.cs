

namespace Altitude.Classes
{
    internal class CalAltitude
    {
        public double AltitudeAtual { get; set; }
        public double Cal { get; set; }
        public string Msg { get; set; }

        public CalAltitude(double altitude)
        {
            AltitudeAtual = altitude;
        }

        public CalAltitude()
        {
        }

        public void Distance(double altitude)
        {
            Cal = altitude - AltitudeAtual;
            AltitudeAtual = altitude;
        }
        public void MensagemDeAviso()
        {
            if (Cal <= -20.0)
            { Msg = "Danger!!:A queda de altitude está muito perigosa"; }
            else if (Cal <= -11.0)
            { Msg = "Alerta!: Cuidado,a perda de altitude está acima do normal"; }
            else
            { Msg = "Normal: A queda de altitude está normal"; }
        }
        public async Task ProcessamentodeTempo()
        {
            await Task.Delay(3000);
        }
        public override string ToString()
        {
            if (Cal < 0)
            {
                return $"Altitude atual:{AltitudeAtual}\nEstamos diminuindo a altitude {Cal}M/S\n------\n{Msg}";
            }
            else if (Cal == 0)
            {
                return $"Altitude atual:{AltitudeAtual}\nEstamos na mesma altura!!!";
            }
            return $"Altitude atual:{AltitudeAtual}\nVoando e subindo!! Você teve um aumento de {Cal}M/S";
        }
    }
}