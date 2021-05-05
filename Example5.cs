using System;

namespace Example5
{
    class Program
    {
        static int ArrayMax(int[] array)
        {
            var maxValue = int.MinValue;
            foreach (var element in array)
            {
                if (maxValue < element)
{
                    maxValue = element;
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($" Максимальне значення масиву {ArrayMax(a)}");
            Console.ReadLine();
        }

    }
}
