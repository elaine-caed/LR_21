using System;

namespace Example6
{
    class Program
    {
        static void ChangeToAbs(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }
        }
        static void Main(string[] args)
        {
            var a = new[] { -2, 5, 7, 3, -9, -6, 0, -1 };
            ChangeToAbs(a);
            Console.WriteLine(string.Join(", ", a));
            Console.ReadLine();
        }
    }
}
