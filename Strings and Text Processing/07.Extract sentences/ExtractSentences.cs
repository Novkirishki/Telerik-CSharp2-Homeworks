using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.

namespace _07.Extract_sentences
{
    class ExtractSentences
    {
        static void Extract(string text, string keyword)
        {
            string[] arr =  text.Split( new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length; i++)
            {
                string[] words = Regex.Split(arr[i], @"\W+");

                for (int j = 0; j < words.Length; j++)
                {
                    if (keyword.Equals(words[j]))
                    {
                        Console.WriteLine("{0}.", arr[i]);
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            Console.WriteLine("Input keyword:");
            string keyword = Console.ReadLine();

            Extract(text, keyword);
        }
    }
}
