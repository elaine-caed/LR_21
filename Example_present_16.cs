using System;

namespace _16
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
            string nstr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                nstr += str[i];
            }
            return nstr;
        }
    }
}
