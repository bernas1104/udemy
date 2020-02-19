using System;
using System.Globalization;
using Section_11.Ex1;
using Section_11.Ex2;

namespace Section_11
{
    class Program
    {
        public void Ex1()
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation res = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + res.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("New check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("New check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                res.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + res.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception error: " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                // Ex2
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.ToString());
            }
            catch(WithdrawException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception error: {e.Message}");
            }
        }
    }
}
