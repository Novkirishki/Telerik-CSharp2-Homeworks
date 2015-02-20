using System;

//Write a method that reverses the digits of given decimal number.

namespace _07.Reverse_number
{
    class ReverseNumber
    {
        static double Reverse(double number)
        {
            string n = number.ToString();
            char[] arr = n.ToCharArray();
            Array.Reverse(arr);
            n = new string(arr);
            return double.Parse(n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("The reversed number is: {0}", Reverse(number));
        }
    }
}
