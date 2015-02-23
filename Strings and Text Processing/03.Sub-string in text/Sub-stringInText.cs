using System;

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

namespace _03.Sub_string_in_text
{
    class Program
    {
        static int CountOFSubstrings(string text, string substring)
        {
            int counter = 0;
            int index = 0;
            int found = 0;
            while (true)
            {
                found = text.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase);
                if (found < 0)
                {
                    break;
                }

                index = found + substring.Length;
                counter++;
            }

            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Input a substring: ");
            string substring = Console.ReadLine();

            Console.WriteLine(CountOFSubstrings(text, substring));
        }
    }
}
