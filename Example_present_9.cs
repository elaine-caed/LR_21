using System;

namespace _9
{
    class Program
    {
        private static void Main(string[] args)
        {
            SumAndPrint(2, 3);
            SumAndPrint(2.0, 3.1);
            Console.ReadKey();
        }
        private static void SumAndPrint(double d1, double d2)
        {
            Console.WriteLine(d1 + d2);
        }
        private static void SumAndPrint(int d1, int d2)
        {
            Console.WriteLine(d1 + d2);
        }
    }
}
