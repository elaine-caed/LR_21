using System;

namespace _12
{
    class Program
    {
        private static int[,] InitArray(int n, int m)
        {
            Random rand = new Random();
            int[,] mas = new int[n, m];
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = rand.Next(10, 100);
            return mas;
        }
        private static int[][] InitJuggedArray(int n, int m)
        {
            Random rand = new Random();
            int[][] mas = new int[n][];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new int[m];
            }
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = rand.Next(10, 100);
                }
            }
            return mas;
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
        private static void PrintArray(int[][] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                    Console.Write($"{mas[i][j]} ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[][] mas = InitJuggedArray(3, 4);
            int[,] mas2 = InitArray(3, 4);
            PrintArray(mas);
            Console.WriteLine();
            PrintArray(mas2);
        }
    }
}
