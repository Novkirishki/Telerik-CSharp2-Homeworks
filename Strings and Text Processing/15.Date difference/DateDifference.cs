using System;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

namespace _15.Date_difference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first date: ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", null);
            Console.WriteLine("Enter the second date: ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", null);

            Console.WriteLine("Distance {0}", (endDate - startDate).TotalDays);
        }
    }
}
