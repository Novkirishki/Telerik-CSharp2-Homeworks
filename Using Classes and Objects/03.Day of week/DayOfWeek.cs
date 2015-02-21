using System;

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

namespace _03.Day_of_week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Today is {0}", date.DayOfWeek);
        }
    }
}
