using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            string nome;
            double preco;
            int quantidade;

            Console.WriteLine("Defina um produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            p = new Produto(nome, preco, quantidade);
            Console.WriteLine(p);
        }
    }
}
