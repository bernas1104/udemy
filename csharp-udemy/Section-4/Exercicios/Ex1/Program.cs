using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            double AreaX, AreaY;
            Triangulo X;
            Triangulo Y;

            Console.WriteLine("Defina o triangulo X:");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            X = new Triangulo(x, y, z);
            AreaX = X.Area();

            Console.WriteLine("Defina o triangulo Y:");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Y = new Triangulo(x, y, z);
            AreaY = Y.Area();

            Console.WriteLine("Área triangulo X: " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área triangulo Y: " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if(AreaX > AreaY)
            {
                Console.WriteLine("Triangulo X tem área maior!");
            }
            else
            {
                Console.WriteLine("Triangulo Y tem área maior!");
            }
        }
    }
}
