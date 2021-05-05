using System;

namespace Example10
{
    class Program
    {
        static uint[] FibonacciNumbers(uint n)
            {
                uint[] arr = new uint[n];
                n -= 1;
                if (n == 0)
                {
                    arr[0] = 1;
                }
                else
                {
                    arr[0] = 1;
                    arr[1] = 1;
                }
                for (int i = 2; i <= n; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
                return arr;
            }

            static void Main(string[] args)
            {
                Console.Write("N = ");
                var n = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"{n} перших чисел послiдовностi Фiбоначчi");
                Console.WriteLine(string.Join(", ", FibonacciNumbers(n)));
            }
        }
    }

