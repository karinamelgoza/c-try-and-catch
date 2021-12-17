using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string userInput = Console.ReadLine();

            int userInputAsInt = int.Parse(userInput);

            Console.ReadKey();
        }
    }
}
