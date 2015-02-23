using System;

//You are given a text. Write a program that changes the text in all regions 
//surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

namespace _04.Parse_tags
{
    class ParseTags
    {
        static string Parser(string text)
        {
            int startIndex = 0;
            int endIndex = 0;
            int found = 0;
            while (true)
            {
                found = text.IndexOf("<upcase>", 0, StringComparison.OrdinalIgnoreCase);
                if (found < 0)
                {
                    break;
                }

                startIndex = found + "<upcase>".Length;

                found = text.IndexOf("</upcase>", startIndex, StringComparison.OrdinalIgnoreCase);
                endIndex = found + "</upcase>".Length;

                string textToUpper = text.Substring(startIndex, endIndex - startIndex - "</upcase>".Length).ToUpper();
                string toBeReplaced = text.Substring(startIndex - "<upcase>".Length, endIndex - startIndex + "<upcase>".Length);
                text = text.Replace(toBeReplaced, textToUpper);
            }

            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string text = Console.ReadLine();

            Console.WriteLine(Parser(text));
        }
    }
}
