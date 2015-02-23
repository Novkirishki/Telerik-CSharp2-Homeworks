using System;

//Write a program that reads a string, reverses it and prints the result at the console.

namespace _01.Reverse_string
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string a = Console.ReadLine();
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }
    }
}
