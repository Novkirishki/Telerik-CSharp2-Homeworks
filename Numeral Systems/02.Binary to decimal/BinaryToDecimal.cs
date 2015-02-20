using System;

//Write a program to convert binary numbers to their decimal representation.

namespace _02.Binary_to_decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a binary number: ");
            String number = Console.ReadLine();
            int fromBase = 2;
            int toBase = 10;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("The number in decmal is: {0}", result);
        }
    }
}
