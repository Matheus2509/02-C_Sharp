using System.Globalization;

namespace Projeto_Copilot
{
    internal class Carros
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carros(string marca, string modelo, int ano) {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public override string ToString()
        {
            return $"A marca do carro é {Marca} do ano de {Ano} do modelo {Modelo}";
        }
    }
}
