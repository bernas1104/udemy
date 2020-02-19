using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            string[] tamanho = Console.ReadLine().Split(' ');
            string[] elementos;

            int m = int.Parse(tamanho[0]);
            int n = int.Parse(tamanho[1]);

            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                Console.Write("Digite os " + n + " elementos da " + i + "-ésima linha: ");
                elementos = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(elementos[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite um X da matriz: ");
            int elemento = int.Parse(Console.ReadLine());

            int posM = 0, posN = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == elemento)
                    {
                        posM = i;
                        posN = j;

                        Console.WriteLine("Posição: " + i + ", " + j);

                        if (posN != 0)
                        {
                            Console.WriteLine("Elemento à esquerda de X: " + matriz[posM, posN - 1]);
                        }

                        if (posM != 0)
                        {
                            Console.WriteLine("Elemento acima de X: " + matriz[posM - 1, posN]);
                        }

                        if (posN != (n - 1))
                        {
                            Console.WriteLine("Elemento à direita de X: " + matriz[posM, posN + 1]);
                        }

                        if (posM != (m - 1))
                        {
                            Console.WriteLine("Elemento abaixo de X: " + matriz[posM + 1, posN]);
                        }
                    }
                }
            }
        }
    }
}
