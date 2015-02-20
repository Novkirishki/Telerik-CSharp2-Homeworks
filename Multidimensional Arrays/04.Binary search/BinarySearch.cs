using System;

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

namespace _04.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert k:");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int index = Array.BinarySearch(arr, k);
            index = (-index) - 1;

            Console.WriteLine("The largest number <= K is: {0}", arr[index]);
        }
    }
}
