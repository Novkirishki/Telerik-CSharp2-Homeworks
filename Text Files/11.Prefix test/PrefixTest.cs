using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

namespace _11.Prefix_test
{
    class PrefixTest
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Match match = Regex.Match(line, @"\btest\w*\b");
                    while (match.Success)
                    {
                        line = line.Replace(match.ToString(), "");
                        match = match.NextMatch();
                    }
                    builder.AppendLine(line);
                    line = reader.ReadLine();
                }
            }

            File.WriteAllText("result.txt", builder.ToString());
        }
    }
}
