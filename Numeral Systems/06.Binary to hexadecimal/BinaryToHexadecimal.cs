using System;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace _06.Binary_to_hexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a binary number: ");
            String number = Console.ReadLine();
            int fromBase = 2;
            int toBase = 16;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("The number in hexadecimal is: {0}", result);
        }
    }
}
