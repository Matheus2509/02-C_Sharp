using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classe
{
    internal class Produto
    {
        public string Produtos { get; set; }
        public double Preço { get; set; }
        public Produto()
        {

        }
        public Produto(string produtos, double preço)
        {
            Produtos = produtos;
            Preço = preço;
        }

        public override string ToString()
        {
            return $"Nome: {Produtos}\nPreço: {Preço.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
