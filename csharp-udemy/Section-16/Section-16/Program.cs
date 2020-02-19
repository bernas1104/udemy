using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

using Entities;

namespace Section16
{
    class Program
    {
        public static void Ex1()
        {
            // Specify the data source.
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression.
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => 10 * x);

            // Execute the query.
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }

        public static void Ex2()
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();

            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string nome = line.Split(',')[0];
                double preco = double.Parse(line.Split(',')[1], CultureInfo.InvariantCulture);

                Product p = new Product(nome, preco);
                products.Add(p);
            }

            double avg = products.Average(x => x.Preco);
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Product p in products.Where(x => x.Preco < avg).OrderByDescending(x => x.Nome).Select(x => x))
            {
                Console.WriteLine(p);
            }
        }

        public static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();

            string[] lines = File.ReadAllLines(path);

            foreach(string line in lines)
            {
                string[] info = line.Split(',');
                string nome = info[0];
                string email = info[1];
                double salario = double.Parse(info[2], CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(nome, email, salario);
                funcionarios.Add(funcionario);
            }

            Console.Write("Enter salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than " + baseSalary.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Funcionario x in funcionarios.Where(x => x.Salario > baseSalary).OrderBy(x => x.Email))
            {
                Console.WriteLine(x.Email);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + funcionarios.Where(x => x.Nome[0] == 'M').Sum(x => x.Salario).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
