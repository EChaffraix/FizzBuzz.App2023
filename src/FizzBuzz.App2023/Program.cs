using System;

namespace FizzBuzz.App2023
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzz game = new FizzBuzz();
            for (int i = 1; i <= 100; i++)
            {
                var result = game.Play(i);
                Console.WriteLine(result);
            }
        }
    }
}
