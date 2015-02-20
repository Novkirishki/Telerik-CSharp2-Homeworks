using System;

//Write a program that finds the sequence of maximal sum in given array.

namespace _08.Maximal_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int max = 0;
            int currentMax = 0;
            bool areNegative = true;
            int br = 0;
            int currentBr = 0;
            int index = 0;


            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxNumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }
            }


            if (maxNumber < 0)
            {
                Console.WriteLine(maxNumber);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    currentMax += arr[i];
                    currentBr++;
                    if (currentMax < 0)
                    {
                        currentMax = 0;
                        currentBr = 0;
                    }
                    if (max < currentMax)
                    {
                        max = currentMax;
                        br = currentBr;
                        index = i - br + 1;
                    }
                }

                for (int i = index; i < index + br; i++)
                {
                    Console.Write("{0} ",arr[i]);
                }
            }
        }
    }
}
