using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Test.Classe
{
    sealed internal class Usados : Produto
    {
        public DateTime Fabricação { get; private set; }

        public Usados(string produtos, double preço, DateTime fabricação) : base(produtos, preço)
        {
            Fabricação = fabricação;
        }
        public override string ToString()
        {
            return $"Nome: {Produtos}\nPreço: {Preço.ToString("F2", CultureInfo.InvariantCulture)}\nFabricação: {Fabricação.ToString("dd/MM/yyyy")}";
        }
    }
}
