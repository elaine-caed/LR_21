using System;

namespace Example2
{
    class Program
    {
        private static double DivWithoutExeption(double x, double y)
        {
            if (y == 0)
            {
                return double.MaxValue;
            }
            else
            {
                return x / y;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DivWithoutExeption(1, 0));
            Console.WriteLine(DivWithoutExeption(15.1, 2));
        }
    }
}
