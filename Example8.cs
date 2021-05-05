using System;

namespace Example8
{
    class Program
    {
        static ulong Factorial(uint n)
        {
            return n == 0 ? 1 : Factorial(n - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($" Факторіал числа {n} рівний {Factorial(n)}");
            Console.ReadLine();
        }
    }
}
