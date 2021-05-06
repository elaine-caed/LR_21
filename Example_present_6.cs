using System;

namespace _6
{
    class Program
    {
        private static void Main(string[] args)

        {
            int a = Sum2Arg(2, 3);
            int b = Sum3Arg(2, 3, 4);
            int c = Sum4Arg(2, 3, 4, 5);
            Console.WriteLine($"a={a} b={b} c={c}");
            Console.ReadKey();
        }
        private static int Sum4Arg(int i1, int i2, int i3, int i4)
        {
            return i1 + i2 + i3 + i4;
        }
        private static int Sum3Arg(int i1, int i2, int i3)
        {
            return i1 + i2 + i3;
        }
        private static int Sum2Arg(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
