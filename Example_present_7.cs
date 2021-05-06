using System;

namespace _7
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a = Sum(2, 3);
            int b = Sum(2, 3, 4);
            int c = Sum(2, 3, 4, 5);
            Console.WriteLine($"a={a} b={b} c={c}");
            Console.ReadKey();
        }
        private static int Sum(int i1, int i2, int i3, int i4)
        {
            return i1 + i2 + i3 + i4;
        }
        private static int Sum(int i1, int i2, int i3)
        {
            return i1 + i2 + i3;
        }
        private static int Sum(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
