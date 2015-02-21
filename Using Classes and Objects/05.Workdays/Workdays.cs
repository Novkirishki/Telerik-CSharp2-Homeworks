using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a 
//fixed list of public holidays specified preliminary as array.

namespace _05.Workdays
{
    class Workdays
    {
        static void CalculateWorkdays(DateTime date, DateTime[] holidays)
        {
            int workdays = 0;
            bool flag = false;
            DateTime start;
            DateTime end;
            if (date > DateTime.Now)
            {
                start = DateTime.Now.Date;
                end = date;
            }
            else
            {
                start = date;
                end = DateTime.Now.Date;
            }
            end = end.AddDays(1);

            do
            {
                if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (start == holidays[i])
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                        flag = false;
                    }
                    else
                    {
                        workdays++;
                    }                  
                }
                start = start.AddDays(1);
            } 
            while (start < end);

            Console.WriteLine("Number of workdays is {0}", workdays);
        }
        static void Main(string[] args)
        {
            DateTime[] holidays = new DateTime[1];
            holidays[0] = new DateTime(2015, 3, 3);
            CalculateWorkdays(new DateTime(2015,3,10), holidays); 
        }
    }
}
