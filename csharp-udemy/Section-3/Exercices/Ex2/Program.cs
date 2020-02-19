using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite qual exercício executar (1 a 4): ");
                int sel = int.Parse(Console.ReadLine());

                if (sel == 0)
                    break;

                if (sel >= 1 && sel <= 4)
                    Console.WriteLine("===== Exercício " + sel + " =====");

                switch (sel)
                {
                    case 1:
                        Console.WriteLine("Digite um número inteiro:");
                        int nro = int.Parse(Console.ReadLine());

                        if (nro >= 0)
                            Console.WriteLine("NAO NEGATIVO");
                        else
                            Console.WriteLine("NEGATIVO");
                        break;
                    case 2:
                        Console.WriteLine("Digite dois números inteiros:");
                        string[] ab = Console.ReadLine().Split(' ');

                        int a = int.Parse(ab[0]);
                        int b = int.Parse(ab[1]);

                        int rst;
                        if(a >= b)
                            rst = a % b;
                        else
                            rst = b % a;

                        if(rst > 0)
                            Console.WriteLine("Não são Multíplos");
                        else
                            Console.WriteLine("São Multíplos");
                        break;
                    case 3:
                        Console.WriteLine("Digite o código e a quantidade do item:");
                        string[] cq = Console.ReadLine().Split(' ');

                        int cod = int.Parse(cq[0]);
                        float qnt = float.Parse(cq[1], CultureInfo.InvariantCulture);

                        double total;
                        if (cod == 1)
                            total = 4.00 * (double)qnt;
                        else if (cod == 2)
                            total = 4.50 * (double)qnt;
                        else if (cod == 3)
                            total = 5.00 * (double)qnt;
                        else if (cod == 4)
                            total = 2.00 * (double)qnt;
                        else
                            total = 1.50 * (double)qnt;

                        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 4:
                        Console.WriteLine("Escreva um X e um Y (separados por espaço):");
                        string[] xy = Console.ReadLine().Split(' ');

                        double x = double.Parse(xy[0], CultureInfo.InvariantCulture);
                        double y = double.Parse(xy[1], CultureInfo.InvariantCulture);

                        if (x == 0.0 && y == 0.0)
                            Console.WriteLine("Origem");
                        else if (x > 0.0)
                        {
                            if(y > 0.0)
                                Console.WriteLine("Q1");
                            else
                                Console.WriteLine("Q4");
                        }
                        else
                        {
                            if(y > 0.0)
                                Console.WriteLine("Q2");
                            else
                                Console.WriteLine("Q3");
                        }
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }

            Console.WriteLine("Saindo...");
        }
    }
}
