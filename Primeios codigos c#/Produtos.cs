using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeios_codigos_c_
{
    internal class Produtos
    {
        public int Quant;
        public string Name;
        public double Preco;

        public double ValorTotal()
        {
            return Preco * Quant;
        }
        public void Adicionar(int quantidade)
        {
           Quant +=quantidade;

        }
        public void Retirar(int quantidade)
        {
            Quant -= quantidade;

        }

        public override string ToString()
        {
            return Name 
                + "| $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                +"| Quantidade: "
                + Quant
                + "| Valor total de estoque: $ "
                + ValorTotal().ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
