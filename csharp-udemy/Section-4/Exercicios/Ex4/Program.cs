using System;
using System.Globalization;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + x.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO: " + x.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL: " + x.Diagonal().ToString("F2"));
        }
    }
}
