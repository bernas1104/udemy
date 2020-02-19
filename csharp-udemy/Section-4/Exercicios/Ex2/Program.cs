using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            int Idade;
            float Salario;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Idade = int.Parse(Console.ReadLine());
            Pessoa A = new Pessoa(Nome, Idade);

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Idade = int.Parse(Console.ReadLine());
            Pessoa B = new Pessoa(Nome, Idade);

            if(A.Idade > B.Idade)
                Console.WriteLine("Pessoa mais velha: " + A.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + B.Nome);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario C = new Funcionario(Nome, Salario);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario D = new Funcionario(Nome, Salario);

            Console.WriteLine("Salário médio = " + ((C.Salario + D.Salario)/2.0).ToString("F2"));
        }
    }
}
