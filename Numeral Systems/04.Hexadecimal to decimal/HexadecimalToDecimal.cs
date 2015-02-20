using System;

//Write a program to convert hexadecimal numbers to their decimal representation.

namespace _04.Hexadecimal_to_decimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a hexadecimal number: ");
            String number = Console.ReadLine();
            int fromBase = 16;
            int toBase = 10;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("The number in decimal is: {0}", result);
        }
    }
}
