using System;

namespace _04
{
    class Program
    {
        static int Primary(int arg)
        {
            int result = 0;

            for (long i = 2; i <= arg; i = i + 1)
            {
                if ((i % 2 != 0) || (i == 2))
                {
                    result += arg;
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result {Primary(number)}");
        }
    }
}
