using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sel;

            do
            {
                Console.Write("Qual exercício rodar (0 para sair)? ");
                sel = int.Parse(Console.ReadLine());

                switch (sel)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.WriteLine("===== Exercício 1 =====");
                        Console.Write("Digite o 1o número: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o 2o número: ");
                        int n2 = int.Parse(Console.ReadLine());

                        int soma = n1 + n2;

                        Console.WriteLine("SOMA = " + soma);
                        break;
                    case 2:
                        Console.WriteLine("===== Exercício 2 =====");
                        Console.Write("Digite a área da circunferência: ");
                        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        double area = Math.PI * Math.Pow(raio, 2.0);
                        Console.WriteLine("A=" + area.ToString("F4"));
                        break;
                    case 3:
                        Console.WriteLine("===== Exercício 3 =====");
                        Console.WriteLine("Digite 4 números A, B, C e D:");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());

                        int diff = (a * b) - (c * d);
                        Console.WriteLine("DIFERENÇA = " + diff);
                        break;
                    case 4:
                        Console.WriteLine("===== Exercício 4 =====");
                        Console.WriteLine("Digite o número do funcionário, horas trabalhadas e salário/hora:");
                        int nro = int.Parse(Console.ReadLine());
                        int hrs = int.Parse(Console.ReadLine());
                        float pay = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        float tPay = pay * hrs;

                        Console.WriteLine("NUMBER = " + nro);
                        Console.WriteLine("SALARY = U$" + tPay.ToString("F2"));
                        break;
                    case 5:
                        Console.WriteLine("===== Exercício 5 =====");
                        Console.Write("Digite o código, número de, e valor unitário da peça 1 (separado por espaços): ");
                        string[] p1 = Console.ReadLine().Split(' ');

                        Console.Write("Digite o código, número de, e valor unitário da peça 2 (separado por espaços): ");
                        string[] p2 = Console.ReadLine().Split(' ');

                        int cp1 = int.Parse(p1[0]);
                        int np1 = int.Parse(p1[1]);
                        float vp1 = float.Parse(p1[2], CultureInfo.InvariantCulture);

                        int cp2 = int.Parse(p2[0]);
                        int np2 = int.Parse(p2[1]);
                        float vp2 = float.Parse(p2[2], CultureInfo.InvariantCulture);

                        float total = (np1 * vp1) + (np2 * vp2);

                        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
                        break;
                    case 6:
                        Console.WriteLine("===== Exercício 6 =====");
                        Console.WriteLine("Digite três valores A, B e C: (ponto flutuante)");

                        string[] xyz = Console.ReadLine().Split(' ');

                        double x = double.Parse(xyz[0], CultureInfo.InvariantCulture);
                        double y = double.Parse(xyz[1], CultureInfo.InvariantCulture);
                        double z = double.Parse(xyz[2], CultureInfo.InvariantCulture);

                        // Área Triângulo
                        double areaTG = (x * z) / 2.0;
                        // Área Círculo
                        double areaCI = 3.14159 * z * z;
                        // Área Trapézio
                        double areaTP = ((x * y) / 2.0) * z;
                        // Área Quadrado
                        double areaQD = y * y;
                        // Área Retângulo
                        double areaRT = x * y;

                        Console.WriteLine("TRIANGULO: " + areaTG.ToString("F3"));
                        Console.WriteLine("CIRCULO: " + areaCI.ToString("F3"));
                        Console.WriteLine("TRAPEZIO: " + areaTP.ToString("F3"));
                        Console.WriteLine("QUADRADO: " + areaQD.ToString("F3"));
                        Console.WriteLine("RETANGULO: " + areaRT.ToString("F3"));
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }
            } while (sel != 0);
        }
    }
}
