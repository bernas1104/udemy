using System;
using System.Globalization;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();

            Console.Write("Nome do aluno: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + A.NotaFinal().ToString("F2"));
            A.Aprovado();
        }
    }
}
