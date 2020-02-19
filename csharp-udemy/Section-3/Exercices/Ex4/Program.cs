using System;
using System.Globalization;

namespace Ex4
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
                        int x = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= x; i++)
                        {
                            if (i % 2 == 1)
                                Console.WriteLine(i.ToString());
                        }
                        break;
                    case 2:
                        int n = int.Parse(Console.ReadLine());

                        for(int i = 0; i < n; i++)
                        {
                            string[] fs = Console.ReadLine().Split(' ');

                            float f1 = float.Parse(fs[0], CultureInfo.InvariantCulture);
                            float f2 = float.Parse(fs[1], CultureInfo.InvariantCulture);
                            float f3 = float.Parse(fs[2], CultureInfo.InvariantCulture);

                            double media = ((f1 * 2.0) + (f2 * 3.0) + (f3 * 5.0)) / 10.0;

                            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                        }
                        break;
                    case 3:
                        n = int.Parse(Console.ReadLine());
                        int fat = 1;

                        for (int i = n; i >= 0; i--)
                        {
                            if (i == 0)
                                fat *= 1;
                            else
                                fat *= i;
                        }

                        Console.WriteLine(fat.ToString());
                        break;
                    case 4:
                        int sqr, cub;
                        n = int.Parse(Console.ReadLine());

                        for(int i = 1; i <= n; i++)
                        {
                            sqr = i * i;
                            cub = i * i * i;
                            Console.WriteLine(i.ToString() + " " + sqr.ToString() + " " + cub.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }
    }
}
