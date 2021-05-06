using System;

namespace _13
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
            if (n == 1)
                return 1;
            return n * factorial(n - 1);
        }
    }
}
