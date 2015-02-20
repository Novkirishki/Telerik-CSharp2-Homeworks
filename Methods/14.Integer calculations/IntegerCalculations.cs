using System;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace _14.Integer_calculations
{
    class IntegerCalculations
    {
        static long Sum(params int[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static double Average(params int[] arr)
        {
            return (double)Sum(arr) / arr.Length;
        }

        static int Min(params int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static int Max(params int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static long Product(params int[] arr)
        {
            long product = 1;
            foreach (var item in arr)
            {
                product *= item;
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is: {0}", Sum(1, 2, 3, 4));
            Console.WriteLine("The maximal element is: {0}", Max(1, 2, 3, 4));
            Console.WriteLine("The minimal element is: {0}", Min(1, 2, 3, 4));
            Console.WriteLine("The average is: {0}", Average(1, 2, 3, 4));
            Console.WriteLine("The product is: {0}", Product(1, 2, 3, 4));
        }
    }
}
