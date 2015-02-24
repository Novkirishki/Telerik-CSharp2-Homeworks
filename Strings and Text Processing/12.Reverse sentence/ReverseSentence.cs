using System;

//Write a program that reverses the words in given sentence.

namespace _12.Reverse_sentence
{
    class ReverseSentence
    {
        static string Reverse(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', ',', '-', '(', ')', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                index = sentence.IndexOf(words[i], index);
                sentence = sentence.Remove(index, words[i].Length).Insert(index, words[words.Length - i - 1]);
                index += words[words.Length - i - 1].Length;
            }

            return sentence;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input sentence:");
            string text = Console.ReadLine();

            Console.WriteLine(Reverse(text));
        }
    }
}
