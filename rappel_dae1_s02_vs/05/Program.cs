using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int result = 0;

            foreach (int e in array)
            {
                result += e;
            }

            Console.WriteLine($"result: {result}");
        }
    }
}
