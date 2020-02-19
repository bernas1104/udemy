using System;
namespace Ex4
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        public Retangulo()
        {
        }

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * Altura + 2 * Largura;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }
}
