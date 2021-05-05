using System;

namespace Example1
{
    class Program
    {
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintHello(string name)
        {
            var text = " Hello " + name + " !" ;
            Console.WriteLine(text);
        }
        static int Cube(int x)
        {
            return x * x * x;
        }
        static void Main(string[] args)

        {
            PrintHelloWorld();
            PrintHello(" Andrew ");
            var b1 = Cube(2);
            var b2 = Cube(3);
            Console.ReadLine();
        }
    }
}
