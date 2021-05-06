using System;

namespace _8
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a = Sum(2, 3);
            double b = Sum(2.0, 3.0);
            Console.WriteLine($"a={a} b={b}");
            Console.ReadKey();
        }
        private static double Sum(double d1, double d2)
        {
            return d1 + d2;
        }
        private static int Sum(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
