using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }
    }
}
