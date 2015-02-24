using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal
//number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

namespace _10.Format_number
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15:G}|{0,15:X}|{0,15:P}|{0,15:E}", number);
        }
    }
}
