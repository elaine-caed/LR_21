using System;

namespace _4
{
	class Program
	{
		private static int[] instanceArray(int size, int min, int max)
		{
			Random random = new Random();
			int[] mas = new int[size];
			for (int i = 0; i < mas.Length; i++)
			{
				mas[i] = random.Next(min, max);
			}
			return mas;
		}
		static void Main(string[] args)
		{
			int[] arr = instanceArray(5, 0, 10);
			foreach (int a in arr)
			{
				Console.Write($"{a} ");
			}
		}
	}
}
