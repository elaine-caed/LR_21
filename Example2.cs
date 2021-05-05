using System;

namespace Example2
{
    class Program
    {
        static int Add(int x1, int x2)
        {
            x1 += x2;
            return x1;
        }
        static void Main(string[] args)
        {
            var num1 = 2;
            var num2 = 5;
            var sum = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.ReadLine();
        }
    }
}
