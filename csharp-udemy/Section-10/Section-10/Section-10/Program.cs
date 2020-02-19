using System;
using Section_10.Ex1;
using Section_10.Ex2;
using Section_10.Ex3;
using System.Collections.Generic;
using System.Globalization;

namespace Section_10
{
    class Program
    {
        public void Upndown()
        {
            // UPCASTING/DOWNCASTING
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            // Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // Downcasting
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100);

            // BusinessAccount acc5 = (BusinessAccount) acc3;
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount) acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            // Polimorfismo          
            Account acc6 = new Account(1001, "Alex", 500.0);
            acc6.Withdraw(100);
            Console.WriteLine(acc6.Balance);

            SavingsAccount sacc1 = new SavingsAccount(1002, "Maria", 500.0, 0.01);
            sacc1.Withdraw(100);
            Console.WriteLine(sacc1.Balance);
        }

        public void Exercicio2()
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int products = int.Parse(Console.ReadLine());

            for (int i = 0; i < products; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char opt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opt == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (opt == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, fee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }

        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());

            for(int i = 0; i < payers; i++)
            {
                Console.WriteLine($"Tax payer ##{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                char opt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Pessoa p;
                if(opt == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    p = new PessoaFisica(nome, rendaAnual, gastoSaude);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());

                    p = new PessoaJuridica(nome, rendaAnual, numeroFuncionarios);
                }

                list.Add(p);
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Pessoa p in list)
            {
                Console.WriteLine(p.Nome + ": $ " + p.ImpostosPagos().ToString("F2", CultureInfo.InvariantCulture));
                sum += p.ImpostosPagos();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
