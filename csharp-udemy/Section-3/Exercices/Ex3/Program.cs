using System;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite qual exercício executar (1 ou 2): ");
                int sel = int.Parse(Console.ReadLine());

                if (sel == 0)
                    break;

                if (sel >= 1 && sel <= 2)
                    Console.WriteLine("===== Exercício " + sel + " =====");

                switch (sel)
                {
                    case 1:
                        int password = 2002;
                        int pass;

                        do
                        {
                            Console.WriteLine("Digite a senha:");
                            pass = int.Parse(Console.ReadLine());

                            if (pass != password)
                                Console.WriteLine("Senha Inválida");
                        } while (password != pass);

                        Console.WriteLine("Acesso Permitido");
                        break;
                    case 2:
                        double x = 1.0, y = 1.0;

                        while (x != 0.0 && y != 0.0)
                        {
                            Console.WriteLine("Digite as coordenadas X e Y (separadas por espaço):");
                            string[] xy = Console.ReadLine().Split(' ');

                            x = double.Parse(xy[0], CultureInfo.InvariantCulture);
                            y = double.Parse(xy[1], CultureInfo.InvariantCulture);

                            if (x != 0.0 && y != 0.0)
                            {
                                if (x > 0.0)
                                {
                                    if (y > 0.0)
                                        Console.WriteLine("primeiro");
                                    else
                                        Console.WriteLine("quarto");
                                }
                                else
                                {
                                    if (y > 0.0)
                                        Console.WriteLine("segundo");
                                    else
                                        Console.WriteLine("terceiro");
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção válida!");
                        break;
                }
            }
        }
    }
}
