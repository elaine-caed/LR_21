using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = InitArray(4, 5);
            PrintArray(arr);
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
        private static int[,] InitArray(int n, int m)
        {
            Random rand = new Random();
            int[,] mas = new int[n, m];
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = rand.Next(10, 100);
            return mas;
        }
    }
}
