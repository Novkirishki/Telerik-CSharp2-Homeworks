using System;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

namespace _13.Word_dictionary
{
    class WordDictionary
    {
        static void FindWord(string word, string[] dictionary)
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i].IndexOf(word) == 0)
                {
                    Console.WriteLine("{0}", dictionary[i]);
                    return;
                }
            }
            Console.WriteLine("Word not found.");
        }
        static void Main(string[] args)
        {
            //Sample Dictionary
            //.NET	platform for applications from Microsoft
            //CLR	managed execution environment for .NET
            //namespace	hierarchical organization of classes

            Console.WriteLine("Input the number of words in the dictionary: ");
            int n = int.Parse(Console.ReadLine());
            string[] dictionary = new string[n];

            for (int i = 0; i < dictionary.Length; i++)
            {
                dictionary[i] = Console.ReadLine();
            }

            Console.WriteLine("Input a word: ");
            string word = Console.ReadLine();

            FindWord(word, dictionary);
        }
    }
}
