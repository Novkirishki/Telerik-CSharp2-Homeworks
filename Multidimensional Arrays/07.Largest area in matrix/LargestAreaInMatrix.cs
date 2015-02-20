using System;

//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

namespace _07.Largest_area_in_matrix
{
    class LargestAreaInMatrix
    {
        static int counter = 0;
        static void RecursiveSearch(int[,] arr, bool[,] arr2, int row, int col)
        {
            counter++;
            arr2[row, col] = true;

            if (row > 0 && arr[row, col] == arr[row-1,col] && arr2[row-1,col] == false)
            {
                RecursiveSearch(arr, arr2, row - 1, col);
            }
            if (row > 0 && col > 0 && arr[row, col] == arr[row - 1, col -1] && arr2[row - 1, col -1] == false)
            {
                RecursiveSearch(arr, arr2, row - 1, col - 1);
            }
            if (row > 0 && col < (arr.GetLength(1) - 1) && arr[row, col] == arr[row - 1, col + 1] && arr2[row - 1, col + 1] == false)
            {
                RecursiveSearch(arr, arr2, row - 1, col + 1);
            }
            if (col > 0 && arr[row, col] == arr[row, col - 1] && arr2[row, col - 1] == false)
            {
                RecursiveSearch(arr, arr2, row, col - 1);
            }
            if (col < (arr.GetLength(1) - 1) && arr[row, col] == arr[row, col + 1] && arr2[row, col + 1] == false)
            {
                RecursiveSearch(arr, arr2, row, col + 1);
            }
            if (row < (arr.GetLength(0) - 1) && arr[row, col] == arr[row + 1, col] && arr2[row + 1, col] == false)
            {
                RecursiveSearch(arr, arr2, row + 1, col);
            }
            if (row < (arr.GetLength(0) - 1) && col > 0 && arr[row, col] == arr[row + 1, col - 1] && arr2[row + 1, col - 1] == false)
            {
                RecursiveSearch(arr, arr2, row + 1, col - 1);
            }
            if (row < (arr.GetLength(0) - 1) && col < (arr.GetLength(1) - 1) && arr[row, col] == arr[row + 1, col + 1] && arr2[row + 1, col + 1] == false)
            {
                RecursiveSearch(arr, arr2, row + 1, col + 1);
            }

        }
        static void Main()
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];
            bool[,] isChecked = new bool[n, m];

            Console.WriteLine("Incert the array row by row: ");
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] row = line.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(row[j]);
                    isChecked[i, j] = false;
                }
            }

            int maxSize = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (isChecked[i, j] == false)
                    {
                        RecursiveSearch(arr, isChecked, i, j);
                    }
                    if (maxSize < counter)
                    {
                        maxSize = counter;
                    }
                    counter = 0;
                }
            }

            Console.WriteLine("{0}", maxSize);
        }
    }
}
