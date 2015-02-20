using System;

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

namespace _15.Number_calculations
{
    class NumberCalculations
    {
        static T Sum<T>(params T[] arr)
        {
            dynamic sum = 0;
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

        static T Min<T>(params T[] arr)
        {
            dynamic min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static T Max<T>(params T[] arr)
        {
            dynamic max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static T Product<T>(params T[] arr)
        {
            dynamic product = 1;
            foreach (var item in arr)
            {
                product *= item;
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is: {0}", Sum(1, 2, 3, 4));
            Console.WriteLine("The maximal element is: {0}", Max(1.0, 2.0, 3.0, 4.6547658534));
            Console.WriteLine("The minimal element is: {0}", Min(1.65, 2, 3.7, 4));
            Console.WriteLine("The average is: {0}", Average(1, 2, 3321340, 4));
            Console.WriteLine("The product is: {0}", Product(1.90549, 2, 3, 4));
        }
    }
}
