namespace Conta
{
    internal class Banco
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; set; }

        public Banco(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
           
        }

        public Banco(int numero, string nome, double saldo): this(numero, nome)
        {
            Adição(saldo);
        }

        public void Adição( double amais)
        {
           Saldo += amais;
        }
        public void Subtração(double amenos)
        {
            Saldo -= amenos;
        }

        public override string ToString()
        {
            return $"Olá, {Nome}, você está na conta: {Numero}, seu saldo atual é {Saldo.ToString("F2")}";
        }
    }
}
