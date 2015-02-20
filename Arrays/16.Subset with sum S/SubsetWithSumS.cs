using System;

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

namespace _16.Subset_with_sum_S
{
    class SubsetWithSumS
    {
        static bool existSum(int[] arr, double sum, int end)
        {
            if (sum == 0)
            {
                return true;
            }
            if (sum != 0 && end == 0)
            {
                return false;
            }

            if (sum - arr[end-1] >= 0)
            {
                return existSum(arr, sum, end-1) || existSum(arr, sum - arr[end-1], end-1);
            }
            else
            {
                return existSum(arr, sum, end-1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the sum: ");
            double sum = double.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(existSum(arr, sum, size));
        }
    }
}
