using System;

//Write a program to convert decimal numbers to their binary representation.

namespace _01.Decimal_to_binary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Input a decimal number: ");
            String number = Console.ReadLine();
            int fromBase = 10;
            int toBase = 2;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("The number in binary is: {0}", result);
        }
    }
}
