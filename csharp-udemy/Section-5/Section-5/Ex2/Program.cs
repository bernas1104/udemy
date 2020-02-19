using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c;
            string titular;
            int conta;
            double saldo, valor;
            char qst;

            Console.WriteLine("Digite as informações da conta:");
            Console.Write("Número da conta corrente: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            qst = char.Parse(Console.ReadLine());

            if (qst == 's' || qst == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaCorrente(titular, conta, saldo);
            } else {
                c = new ContaCorrente(titular, conta);
            }

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Valor do depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Valor do saque (será cobrado uma taxa de R$ 5.00): ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);

            Console.WriteLine();
            Console.WriteLine(c);
        }
    }
}
