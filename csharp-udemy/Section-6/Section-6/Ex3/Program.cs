using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> myList = new List<Funcionario>();
            Funcionario func, aux = null;
            int id;

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                aux = myList.Find(x => x.ID == id);
                while (aux != null){
                    Console.WriteLine("ID já está cadastrado... Escolha outro.");
                    Console.Write("ID: ");
                    id = int.Parse(Console.ReadLine());
                    aux = myList.Find(x => x.ID == id);
                }
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func = new Funcionario(id, nome, salary);
                myList.Add(func);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            func = null;
            func = myList.Find(x => x.ID == id);
            if(func != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                percent = 1.0 + (percent / 100.00);
                func.IncreaseSalary(percent);
            }
            else
                Console.WriteLine("There isn't an employee with that ID.");

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario a in myList)
            {
                Console.WriteLine(a);
            }
        }
    }
}
