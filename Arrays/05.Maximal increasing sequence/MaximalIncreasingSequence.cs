using System;

//Write a program that finds the maximal increasing sequence in an array.

namespace _05.Maximal_increasing_sequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int max = 1;
            int currentMax = 1;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    currentMax++;
                    if (currentMax > max)
                    {
                        max = currentMax;
                        index = i + 2 - max;
                    }
                }
                else
                {
                    currentMax = 1;
                }

            }

            for (int i = index; i < index + max; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
