using System.Globalization;


namespace Primeios_codigos_c_
{
    internal class Produtos
    {
        private int Quant;
        public string _name;
        public double Preco { get; private set;}

        public Produtos()
        {

        }

        public Produtos(string name, int quant, double preco){
            Quant = quant;
            _name = name;
            Preco = preco;
        
        }

        public string GetNome()
        {
            return _name;
        }

        public void SetNome(string nome) {
            _name = nome;
        }

        public double ValorTotal()
        {
            return Preco * Quant;
        }
        public void Adicionar(int quantidade)
        {
            Quant += quantidade;

        }
        public void Retirar(int quantidade)
        {
            Quant -= quantidade;

        }

        public override string ToString()
        {
            return _name
                + "| $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                +"| Quantidade: "
                + Quant
                + "| Valor total de estoque: $ "
                + ValorTotal().ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
