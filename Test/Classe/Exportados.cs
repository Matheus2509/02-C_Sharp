using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Test.Classe
{
    sealed internal class Exportados : Produto
    {
        public double Taxa { get; set; }

        public Exportados(string produtos, double preço, double taxa)
        {
            Taxa = taxa;
            Produtos = produtos;
            Preço = TaxaDoAmor(preço, taxa);
        }
        public double TaxaDoAmor(double taxa, double preço)
        {
            return taxa + preço;
        }
        public override string ToString()
        {
            return $"Nome: {Produtos}\nPreço: {Preço.ToString("F2", CultureInfo.InvariantCulture)}\nValor de taxa: {Taxa.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
