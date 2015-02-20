using System;

//Write a method that returns the last digit of given integer as an English word.

namespace _03.English_Digit
{
    class EnglishDigit
    {
        static string LastDigit(int number)
        {
            if (number < 0)
            {
                number = -number;
            }

            switch (number % 10)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 0:
                    return "zero";
                default:
                    return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is: {0}", LastDigit(n));
        }
    }
}
