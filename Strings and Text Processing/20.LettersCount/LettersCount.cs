using System;

//Write a program that reads a string from the console and prints all different
//letters in the string along with information how many times each letter is found.

namespace _20.LettersCount
{
    class LettersCount
    {
        static void CharCount(string text)
        {
            int[] arr = new int[26];
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 123 && (int)text[i] > 96)
                {
                    arr[(int)text[i] - 97]++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} - {1}",(char)(i + 97),  arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();

            CharCount(text);
        }
    }
}
