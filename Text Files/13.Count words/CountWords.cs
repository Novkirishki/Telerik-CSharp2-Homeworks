using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a list of words from the file words.txt and finds
//how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be 
//sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

namespace _13.Count_words
{
    class CountWords
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("words.txt");
                string[] words = Regex.Split(content, @"\W+");

                Dictionary<string, int> dict = new Dictionary<string, int>();
                content = File.ReadAllText("test.txt");

                int counter = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    string regex = string.Format(@"\b{0}\b", words[i]);
                    Match match = Regex.Match(content, regex, RegexOptions.IgnoreCase);
                    while (match.Success)
                    {
                        counter++;
                        match = match.NextMatch();
                    }
                    dict.Add(words[i], counter);
                    counter = 0;
                }

                var items = from pair in dict orderby pair.Value descending select pair;

                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    foreach (KeyValuePair<string, int> pair in items)
                    {
                        writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
