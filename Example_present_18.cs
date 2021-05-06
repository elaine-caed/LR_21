using System;

namespace _18
{
    class Program
    {
        private static bool isOver = false;
        static void Main(string[] args)
        {
            while (!isOver)
            {
                DoSome();
            }
            Console.ReadKey();
        }

        static void DoSome()
        {
            int c;
            Console.WriteLine("Enter number to SQRT\nnot number to exit");
            if (int.TryParse(Console.ReadLine(), out c))
                Console.WriteLine($"sqrt({c})={Math.Sqrt(c)}");
            else
                isOver = true;
        }
    }
}
