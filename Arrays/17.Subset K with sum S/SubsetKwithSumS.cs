using System;

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

namespace _17.Subset_K_with_sum_S
{
    class SubsetKwithSumS
    {
        static bool existSum(int[] arr, double sum, int end, int counter)
        {
            if (sum == 0 && counter >= 0)
            {
                return true;
            }
            if (sum != 0 && end == 0 || counter < 0)
            {
                return false;
            }

            if (sum - arr[end - 1] >= 0)
            {
                return existSum(arr, sum, end - 1, counter) || existSum(arr, sum - arr[end - 1], end - 1, counter - 1);
            }
            else
            {
                return existSum(arr, sum, end - 1, counter);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the sum: ");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the number of elements in the subset: ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(existSum(arr, sum, size, k));
        }
    }
}