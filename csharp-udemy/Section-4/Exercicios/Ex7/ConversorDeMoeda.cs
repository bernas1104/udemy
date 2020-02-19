using System;
namespace Ex7
{
    public class ConversorDeMoeda
    {
        static double IOF = 1.06;
        public ConversorDeMoeda()
        {
        }

        public static double ValorPagoReais(double cotacao, double dolares)
        {
            return cotacao * dolares * IOF;
        }
    }
}
