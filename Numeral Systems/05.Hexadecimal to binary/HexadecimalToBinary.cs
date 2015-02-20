using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05.Hexadecimal_to_binary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a hexadecimal number: ");
            String number = Console.ReadLine();
            int fromBase = 16;
            int toBase = 2;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            Console.WriteLine("The number in binary is: {0}", result);
        }
    }
}
