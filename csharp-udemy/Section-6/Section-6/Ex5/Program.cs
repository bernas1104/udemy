using System;
using System.Collections.Generic;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> Total = new HashSet<int>();
            int Alunos;

            Console.Write("O curso A possui quantos alunos? ");
            Alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");

            for(int i = 0; i < Alunos; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.Write("O curso B possui quantos alunos? ");
            Alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");

            for(int i = 0; i < Alunos; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.Write("O curso C possui quantos alunos? ");
            Alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");

            for(int i = 0; i < Alunos; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            Total.UnionWith(A);
            Total.UnionWith(B);
            Total.UnionWith(C);
            Console.WriteLine("Total de alunos: " + Total.Count);
        }
    }
}
