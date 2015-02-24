using System;
using System.Text;

//Write a program that reads a string from the console and lists all different
//words in the string along with information how many times each word is found.

namespace _21.Words_count
{
    class WordsCount
    {
        static void WordsCounter(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '-', '(', ')', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder wordsAsString = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (wordsAsString.ToString().IndexOf(words[i]) < 0)
                {
                    wordsAsString.Append(" " + words[i]);
                }
            }

            string[] resultWords = wordsAsString.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int counter = 0;
            for (int i = 0; i < resultWords.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (resultWords[i] == words[j])
                    {
                        counter++;
                    }
                }
                resultWords[i] += " " + counter;
                counter = 0;
            }

            for (int i = 0; i < resultWords.Length; i++)
            {
                Console.WriteLine(resultWords[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();

            WordsCounter(text);
        }
    }
}
