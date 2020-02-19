using System;
using System.Globalization;
using Ex2.Entities;
using Ex2.Entities.Enums;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string Dept = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int N = int.Parse(Console.ReadLine());

            Department dept = new Department(Dept);
            Worker worker = new Worker(Name, Level, BaseSalary, dept);

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " contract data:");
                Console.Write("Date (MM/DD/YYYY): ");
                string date = Console.ReadLine();
                DateTime dateP = DateTime.Parse(date);
                Console.Write("Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int Hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(dateP, ValuePerHour, Hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string YearAndMonth = Console.ReadLine();
            int Month = int.Parse(YearAndMonth.Substring(0, 2));
            int Year = int.Parse(YearAndMonth.Substring(3));
            Console.WriteLine(worker);
            Console.WriteLine(worker.Income(Year, Month).ToString("F2"));
        }
    }
}
