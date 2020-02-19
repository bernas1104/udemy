using System;
using System.Globalization;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario X = new Funcionario();

            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            X.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            X.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + X);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.AumentarSalario(percent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + X);
        }
    }
}
