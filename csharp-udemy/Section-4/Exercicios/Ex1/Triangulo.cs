using System;

namespace Ex1
{
    public class Triangulo
    {
        public double LadoA, LadoB, LadoC, P;

        public Triangulo(double a, double b, double c)
        {
            this.LadoA = a;
            this.LadoB = b;
            this.LadoC = c;
        }

        public double Area()
        {
            this.P = (LadoA + LadoB + LadoC) / 2.0;
            return Math.Sqrt(P * (P - LadoA) * (P - LadoB) * (P - LadoC));
        }
    }
}
