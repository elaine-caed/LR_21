using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5 };
            int[,] arr1 = { { 2, 3 }, { 4, 5 } };
            PrintArray(arr);
            PrintArray(arr1);
            Console.ReadKey();
        }
        private static void PrintArray(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write($"{mas[i, j]} ");
                Console.WriteLine();
            }
        }
        private static void PrintArray(int[] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
                Console.Write($"{mas[i]} ");
            Console.WriteLine();
        }
    }
}
