using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

namespace _09.Sorting_array
{
    class SortingArray
    {
        static int Largest(int[] arr, int index)
        {
            int max = arr[index];
            int maxIndex = index;
            for (int i = index + 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
        static void SortDescending(int[] arr)
        {
            int maxIndex = 0;
            int buf = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxIndex = Largest(arr, i);
                buf = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = buf;
            }
        }
        static void SortAscending(int[] arr)
        {
            int maxIndex = 0;
            int buf = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxIndex = Largest(arr, i);
                buf = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = buf;
            }

            Array.Reverse(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array in descending order");
            SortDescending(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}",i, arr[i]);
            }

            Console.WriteLine("The array in ascending order");
            SortAscending(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
