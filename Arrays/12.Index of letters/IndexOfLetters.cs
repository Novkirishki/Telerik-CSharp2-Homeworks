using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

namespace _12.Index_of_letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word:");
            string word = Console.ReadLine();
            word = word.ToLower();

            char[] letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)(i + 96);
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.Write("{0} ", j);  
                    }
                }
            }
        }
    }
}
