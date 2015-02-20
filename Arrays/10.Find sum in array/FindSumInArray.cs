using System;

//Write a program that finds in given array of integers a sequence of given sum S (if present).

namespace _10.Find_sum_in_array
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the sum: ");
            int sum = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int currentSum = 0;
            int start = -1;
            int end = -1;

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == sum)
                    {
                        start = i;
                        end = j;
                        goto Finish;
                    }
                    else if (currentSum > sum)
                    {
                        break;
                    }
                }
                currentSum = 0;
            }

            Finish:
            if (start == -1 )
            {
                Console.WriteLine("Sum is not present");
            }
            else
            {
                for (int k = start; k <= end; k++)
                {
                    Console.Write("{0} ", arr[k]);
                }
            }           
        }
    }
}
