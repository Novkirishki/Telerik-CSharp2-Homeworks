using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada

namespace _18.Dates_from_text_in_Canada
{
    class DatesFromTextInCanada
    {
        static void GetDates(string text)
        {
             Regex dateRegex = new Regex(@"\d{2}.\d{2}.\d{4}", RegexOptions.IgnoreCase);
            //find items that matches with our pattern
            MatchCollection dateMatches = dateRegex.Matches(text);

            foreach (Match date in dateMatches)
            {
                DateTime date1 = DateTime.ParseExact(date.ToString(), "dd.MM.yyyy", null);
                Console.WriteLine(date1);
            }
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();

            GetDates(text);
        }
    }
}
