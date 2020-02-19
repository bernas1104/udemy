using System;
using System.Collections.Generic;
using Section_10.Ex2;

namespace Section_10
{
    class Ex2Run
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int products = int.Parse(Console.ReadLine());

            for(int i = 0; i < products; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Commom, used or imported (c/u/i)?");
                char opt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(opt == 'c')
                {
                    list.Add(new Product(name, price));
                } else if(opt == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

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
    }
}