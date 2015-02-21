using System;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

namespace _01.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Is the year leap? - {0}", DateTime.IsLeapYear(year));
        }
    }
}
