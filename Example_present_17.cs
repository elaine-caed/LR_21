using System;

namespace _17
{
    class Program
    {
        private static int counter;
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 6 };
            PrintArray(arr);
            arr[1] = 2;
            PrintArray(arr);
            Console.WriteLine(counter);
            Console.ReadKey();
        }
        private static void PrintArray(int[] mas)
        {
            counter++;
            for (int i = 0; i < mas.Length; i++)
                Console.Write($"{mas[i]} ");
            Console.WriteLine();
        }
    }
}
