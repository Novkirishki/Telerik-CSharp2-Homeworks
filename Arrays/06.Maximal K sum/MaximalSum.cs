using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

namespace _06.Maximal_K_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert k: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
        }
    }
}
