using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverce("Hello"));
            Console.ReadKey();
        }
        static string Reverce(string str)
        {
            if (str.Length == 1)
                return str;
            return str.Substring(str.Length - 1, 1)
            + Reverce(str.Substring(0, str.Length - 1));
        }
    }
}
