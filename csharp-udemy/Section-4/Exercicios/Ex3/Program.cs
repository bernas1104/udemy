using System;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto X = new Produto();
            int Quantity;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            X.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            X.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + X);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            Quantity = int.Parse(Console.ReadLine());
            X.AdicionarProdutos(Quantity);

            Console.WriteLine("Dados atualizados: " + X);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            Quantity = int.Parse(Console.ReadLine());
            X.RemoverProdutos(Quantity);

            Console.WriteLine("Dados atualizados: " + X);
        }
    }
}
