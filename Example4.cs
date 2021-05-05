using System;

namespace Example4
{
    class Program
    {
        static string Div(int a, int b, out int result)
            {
                if (b == 0)
                {
                    result = int.MinValue;
                    return " На нуль ділити не можна! ";
                }
                else
                {
                    result = a / b;
                    return " ";
                }
            }
        static void PrintResult(string errorText, int res)
            {
                if (string.IsNullOrEmpty(errorText))
                {
                    Console.WriteLine(res);
                }
                else
                {
                    Console.WriteLine(errorText);
                }
            }
        static void Main(string[] args)
            {
                int r1;
                var err1 = Div(64, 8, out r1);
                PrintResult(err1, r1);
                var err2 = Div(34, 0, out int r2);
                PrintResult(err2, r2);
                Console.ReadLine();
            }
    }
}
