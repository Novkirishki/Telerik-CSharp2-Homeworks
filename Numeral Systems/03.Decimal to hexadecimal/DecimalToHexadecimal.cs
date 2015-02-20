using System;

//Write a program to convert decimal numbers to their hexadecimal representation.

namespace _03.Decimal_to_hexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Input a decimal number: ");
            String number = Console.ReadLine();
            int fromBase = 10;
            int toBase = 16;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("The number in hexadecimal is: {0}", result);
        }
    }
}
