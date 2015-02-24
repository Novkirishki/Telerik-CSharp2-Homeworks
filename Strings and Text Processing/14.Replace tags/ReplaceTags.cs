using System;

//Write a program that replaces in a HTML document given as string all the
//tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

namespace _14.Replace_tags
{
    class ReplaceTags
    {
        static string Replace(string text)
        {
            text = text.Replace("<a href=\"", "[URL=");
            text = text.Replace("\">", "]");
            text = text.Replace("</a>", "[/URL]");

            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input text: ");
            string text = Console.ReadLine();

            Console.WriteLine(Replace(text));
        }
    }
}
