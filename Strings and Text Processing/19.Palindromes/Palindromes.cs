using System;

//Write a program that extracts from a given text all palindromes, e.g. `ABBA`, `lamal`, `exe`.

namespace _19.Palindromes
{
    class Palindromes
    {
        static string Reverse(string a)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string a = Console.ReadLine();

            if (a == Reverse(a))
            {
                Console.WriteLine("The word is palindrome");
            }
            else
            {
                Console.WriteLine("The word is not palindrome.");
            }
        }
    }
}
