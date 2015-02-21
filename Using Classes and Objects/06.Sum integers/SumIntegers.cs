using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

namespace _06.Sum_integers
{
    class SumIntegers
    {
        static void CalculateSum(string integers)
        {
            string[] numbers = integers.Split(' ');
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            Console.WriteLine("The sum is {0}", sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the integers to calc their sum: ");
            string ints = Console.ReadLine();
            CalculateSum(ints);
        }
    }
}
