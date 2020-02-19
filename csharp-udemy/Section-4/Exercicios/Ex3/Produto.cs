using System;
namespace Ex3
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return (double)Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
