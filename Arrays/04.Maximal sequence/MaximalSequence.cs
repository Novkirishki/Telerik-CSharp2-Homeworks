using System;

//Write a program that finds the maximal sequence of equal elements in an array.

namespace _04.Maximal_sequence
{
    class MaximalSequence
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
                if (arr[i] == arr[i + 1])
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
