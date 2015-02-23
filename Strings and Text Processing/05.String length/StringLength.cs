using System;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

namespace _05.String_length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                Console.WriteLine("String is too large");
                return;
            }
            text = text.PadRight(20, '*');

            Console.WriteLine(text);
        }
    }
}
