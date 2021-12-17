using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string userInput = Console.ReadLine();
            Console.WriteLine("please enter another number");
            string userInput2 = Console.ReadLine();

            try
            {
                //int userInputAsInt = int.Parse(userInput);
                int num1 = int.Parse(userInput);
                int num2 = int.Parse(userInput2);
                Console.WriteLine($"result: {num1 / num2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("format exception, please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, the number was too long");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("argument null exception, the value was empty(null)");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("divide by zero exception, do not divide by 0");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }



            Console.ReadKey();
        }
    }
}
