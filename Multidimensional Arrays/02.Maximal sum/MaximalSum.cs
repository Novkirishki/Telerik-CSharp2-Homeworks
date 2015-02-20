using System;

//Write a program that reads a rectangular matrix of size N x M and finds 
//in it the square 3 x 3 that has maximal sum of its elements.

namespace _02.Maximal_sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];
            int maxSum = 0;
            int currentSum = 0;

            Console.WriteLine("Incert the array row by row: ");
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] row = line.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(row[j]);
                }
            }

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    currentSum = arr[i, j] + arr[i, j + 1] + arr[i, j + 2] + arr[i + 1, j] + arr[i + 1, j + 1]
                                + arr[i + 1, j + 2] + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
                currentSum = 0;
            }

            Console.WriteLine(maxSum);
        }
    }
}
