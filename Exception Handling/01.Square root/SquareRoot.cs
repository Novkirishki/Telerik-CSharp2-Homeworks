using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

namespace _01.Square_root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer:");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new Exception();
                }
                Console.WriteLine("The sqrt of {0} is {1}", number, Math.Sqrt(number));
            }
            catch
            {
                Console.WriteLine("Invalid Number");    
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
