using System;
using System.Text.RegularExpressions;
using System.IO;

//Write a program that extracts from given XML file all the text without the tags

namespace _10.Extract_text_from_XML
{
    class ExtractTextFromXML
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("file.txt");
            int startIndex = 0;
            int endIndex = 0;
            startIndex = text.IndexOf(">");
            endIndex = text.IndexOf("<", startIndex);
            while (endIndex > 0)
            {
                if (startIndex + 1 != endIndex)
                {
                    Console.WriteLine(text.Substring(startIndex + 1, endIndex - startIndex - 1));
                }
                startIndex = text.IndexOf(">", endIndex + 1);
                endIndex = text.IndexOf("<", endIndex + 1);
            }
        }
    }
}
