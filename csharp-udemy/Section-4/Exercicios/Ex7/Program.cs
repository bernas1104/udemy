using System;
using System.Globalization;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao;
            double dolares;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ValorPagoReais(cotacao, dolares).ToString("F2"));
        }
    }
}
