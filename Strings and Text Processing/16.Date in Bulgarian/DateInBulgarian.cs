using System;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format)
//along with the day of week in Bulgarian.

namespace _16.Date_in_Bulgarian
{
    class DateInBulgarian
    {
        static void Date(DateTime date)
        {
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            string day = string.Empty;

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    day = "Петък";
                    break;
                case DayOfWeek.Monday:
                    day = "Понеделник";
                    break;
                case DayOfWeek.Saturday:
                    day = "Събота";
                    break;
                case DayOfWeek.Sunday:
                    day = "Неделя";
                    break;
                case DayOfWeek.Thursday:
                    day = "Четвъртък";
                    break;
                case DayOfWeek.Tuesday:
                    day = "Вторник";
                    break;
                case DayOfWeek.Wednesday:
                    day = "Сряда";
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0} {1}", date.ToString("d.M.yyyy H:m:s"), day);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input date in this format: day.month.year hour:minute:second ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", null);

            Date(date);
        }
    }
}
