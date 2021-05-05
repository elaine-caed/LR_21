using System;

namespace Example7
{
    class Program
    {
        static float Minimal(params float[] values)
            {
                var min = float.MaxValue;
                for (var i = 0; i < values.Length; i++)
                {
                    if (min > values[i])
                    {
                        min = values[i];
                    }
                }
                return min;
            }
        static void Main(string[] args)
        {
            Console.WriteLine(Minimal()); //3.4E38
            Console.WriteLine(Minimal(2, 5)); //2
            Console.WriteLine(Minimal(6, 5, 4, 3, 1));//1
            Console.WriteLine(Minimal(new[] { 5f, 9f })); //5
            Console.ReadLine();
        }
    }
}
