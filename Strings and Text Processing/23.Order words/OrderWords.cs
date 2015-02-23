using System;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _23.Order_words
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a list of words: ");
            string words = Console.ReadLine();
            string[] listOfWords = words.Split(' ');
            Array.Sort(listOfWords);

            foreach (var item in listOfWords)
            {
                Console.WriteLine("{0}",item);
            }
        }
    }
}
