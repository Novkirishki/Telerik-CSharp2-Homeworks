using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

namespace _09.Unicode_characters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                result.Append("\\u");
                result.Append(String.Format("{0:x4}", (int)c));
            }

            Console.WriteLine(result);
        }
    }
}
