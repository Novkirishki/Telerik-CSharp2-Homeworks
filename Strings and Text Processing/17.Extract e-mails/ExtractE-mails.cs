using System;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _17.Extract_e_mails
{
    class Program
    {
        static void EmailsInText(string text)
        {
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            //find items that matches with our pattern
            MatchCollection emailMatches = emailRegex.Matches(text);

            foreach (Match email in emailMatches)
            {
                Console.WriteLine(email);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inpu text:");
            string text = Console.ReadLine();

            EmailsInText(text);
        }
    }
}
