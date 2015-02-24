using System;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

namespace _24.Extract_text_from_HTML
{
    class ExtractTextFromHTML
    {
        static void ExtractText(string text)
        {
            string title = string.Empty;
            string content = string.Empty;
            int startIndex = text.IndexOf("<title>");
            int endIndex = text.IndexOf("</title>");

            if (startIndex > -1)
            {
                title = text.Substring(startIndex + 7, endIndex - startIndex - 7);
                if (title.IndexOf("<a href=") > -1)
                {
                    startIndex = title.IndexOf("<a href=");
                    endIndex = title.IndexOf(">");
                    title = title.Remove(startIndex, endIndex - startIndex + 1).Insert(startIndex, " ");
                    title = title.Replace("</a>", " ");
                }
            }

            startIndex = text.IndexOf("<p>");
            endIndex = text.IndexOf("</p>");

            if (startIndex > -1)
            {
                content = text.Substring(startIndex + 3, endIndex - startIndex - 3);
                if (content.IndexOf("<a href=") > -1)
                {
                    startIndex = content.IndexOf("<a href=");
                    endIndex = content.IndexOf(">");
                    content = content.Remove(startIndex, endIndex - startIndex + 1).Insert(startIndex, " ");
                    content = content.Replace("</a>", " ");
                }
            }

            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Text: {0}", content);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();

            ExtractText(text);
        }
    }
}
