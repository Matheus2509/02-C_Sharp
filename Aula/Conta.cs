using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Conta
    {
        public string Nome { get; set; }
        public string Id { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(string nome, string id, double depositoInicial, double limiteSaque)
        {
            Nome = nome;
            Id = id;
            Depositar(depositoInicial);
            LimiteSaque = limiteSaque;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            if (saque > Saldo)
            {
                throw new Exceção("Saque maior que o saldo");
            }
            else if (saque > LimiteSaque)
            {
                throw new Exceção("Saque acima do limite permitido");
            }

            Saldo -= saque;
        }
    }
}
