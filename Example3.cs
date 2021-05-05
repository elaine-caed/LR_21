using System;

namespace Example3
{
    class Program
    {
        static int Mult(ref int x1, int x2)
        {
            x1 *= x2;
            return x1;
        }
        static void Main(string[] args)
        {
            var n1 = 24;
            var n2 = 4;
            var mult = Mult(ref n1, n2);

            Console.WriteLine($"{n1}");
            Console.ReadLine();
        }
    }
}
