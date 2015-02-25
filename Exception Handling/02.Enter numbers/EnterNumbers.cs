using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.Enter_numbers
{
    class EnterNumbers
    {
        static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter an integer number in the range [{0}, {1}]", start, end);
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new Exception("The number is not in the given range");
                }
            }
            catch
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(i * 10 + 1, (i + 1) * 10);
            }
        }
    }
}
