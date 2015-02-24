using System;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

namespace _08.Forbidden_words
{
    class ForbiddenWords
    {
        static string HideForbiddenWords(string text, string words)
        {
            string[] forbiddenWords = words.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                forbiddenWords[i] = forbiddenWords[i].Trim();
                int found = 0;
                int index = 0;
                while (true)
                {
                    index = text.IndexOf(forbiddenWords[i]);
                    if (index < 0)
                    {
                        break;
                    }

                    string replacement = new string('*', forbiddenWords[i].Length);
                    text = text.Replace(forbiddenWords[i], replacement);
                }
            }

            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            Console.WriteLine("Forbidden words: ");
            string words = Console.ReadLine();

            Console.WriteLine(HideForbiddenWords(text, words));
        }
    }
}
