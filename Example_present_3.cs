using System;

namespace _3
{
    class Program
    {
        static void PrintDigit()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(11));
        }
        static void Main(string[] args)
        {
            PrintDigit();
        }
    }
}
