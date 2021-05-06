using System;

namespace Work4
{
    class Program
    {
        static int IndexMax(int[] array, int len)
        {
            if (len == 0)
            {
                return len;
            }
            int i = IndexMax(array, len - 1);
            return array[len] > array[i] ? len : i;
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Index max: {IndexMax(array, array.Length - 1)}");
        }

    }
}
