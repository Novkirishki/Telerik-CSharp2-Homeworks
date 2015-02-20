using System;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace _08.Binary_short
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            short number = short.Parse(Console.ReadLine());

            String result = Convert.ToString(number, 2);
            result =  result.PadLeft(16, '0');
            Console.WriteLine("The number in binary is: {0}", result);
        }
    }
}
