using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

namespace _12.Remove_words
{
    class RemoveWords
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("words.txt");
                string[] words = Regex.Split(content, @"\W+");
                content = File.ReadAllText("file.txt");
                for (int i = 0; i < words.Length; i++)
                {
                    string regex = string.Format(@"\b{0}\b", words[i]);
                    Match match = Regex.Match(content, regex, RegexOptions.IgnoreCase);
                    while (match.Success)
                    {
                        content = content.Replace(match.ToString(), "");
                        match = match.NextMatch();
                    }
                }
                File.WriteAllText("file.txt", content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
