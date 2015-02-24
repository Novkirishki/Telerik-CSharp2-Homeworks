using System;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and replaces all series 
//of consecutive identical letters with a single one.

namespace _22.Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string:");
            string text = Console.ReadLine();

            var regex = new Regex("(.)\\1+");

            Console.WriteLine(regex.Replace(text, "$1")); // something like! this
        }
    }
}
