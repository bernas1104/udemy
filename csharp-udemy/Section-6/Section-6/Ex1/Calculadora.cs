using System;
namespace Ex1
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            return sum;
        }

        public static void Triple(ref int origin, out int result)
        {
            result = origin*3;
        }
    }
}
