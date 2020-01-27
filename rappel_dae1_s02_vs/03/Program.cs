using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Nombre 1: ");
            input = Console.ReadLine();
            int nb1 = Int32.Parse(input);

            Console.Write("Nombre 2: ");
            input = Console.ReadLine();
            int nb2 = Int32.Parse(input);

            Console.Write("Operateur: ");
            input = Console.ReadLine();
            var op = input;

            float result = 0;
            switch(op)
            {
                case "+":
                    result = nb1 + nb2;
                    break;
                case "-":
                    result = nb1 - nb2;
                    break;
                case "/":
                    result = nb1 / nb2;
                    break;
                case "*":
                    result = nb1 / nb2;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine($"Result =  {result}");
        }
    }
}
