using System;

namespace Section15
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 12, 23, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
