using System;

//Write a program that finds the index of given element in a sorted array of integers by
//using the Binary search algorithm.

namespace _11.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the element to be searched: ");
            int element = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int first = 0;
            int last = n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            while (last >= first)
            {
                if (arr[(first + last) / 2] == element)
                {
                    Console.WriteLine("The index is {0}", (first + last) / 2);
                    return;
                }
                if (arr[(first + last) / 2] > element)
                {
                    last = (first + last) / 2 - 1;
                }
                else if (arr[(first + last) / 2] < element)
                {
                    first = (first + last) / 2 + 1;
                }
            }


                Console.WriteLine("There is no such element in the array");
            
        }
    }
}
