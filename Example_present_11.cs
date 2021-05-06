using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mas = InitJuggedArray(3, 4);
            int[,] mas2 = InitArray(3, 4);
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
        private static int[][] InitJuggedArray(int n, int m)
        {
            Random rand = new Random();
            int[][] mas = new int[n][];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = new int[m];
            for (int i = 0; i < mas.Length; i++)
                for (int j = 0; j < mas[i].Length; j++)
                    mas[i][j] = rand.Next(10, 100);
            return mas;
        }
    }
}
