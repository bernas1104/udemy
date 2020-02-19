using System;
using System.Collections.Generic;
using Ex4.Entities;
using Ex4.Entities.Enums;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine(); ;
            Console.Write("Birth date (MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order;
            OrderItem item;
            List<OrderItem> items = new List<OrderItem>();
            Product product;
            double price;
            int quantity;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine());

                product = new Product(name, price);

                Console.Write("Product quantity: ");
                quantity = int.Parse(Console.ReadLine());

                item = new OrderItem(quantity, product);
                items.Add(item);
            }

            order = new Order(status, client, items);

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.Write(order);
        }
    }
}
