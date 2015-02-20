using System;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0:0,00}   ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            //Matrix 1
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = i + 1 + j * matrix.GetLength(0);
                }
            }

            PrintArray(matrix);

            //Matrix2
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = i + 1 + j * matrix.GetLength(0);
                    }
                    else
                    {
                        matrix[i, j] = (j + 1) * matrix.GetLength(0) - i;
                    }
                }
            }

            PrintArray(matrix);

            //Matrix 3
            int counter = 1;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                int row = i;
                int col = 0;
                while (row < matrix.GetLength(0))
                {
                    matrix[row, col] = counter++;
                    row++;
                    col++;
                }
            }
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                int row = 0;
                int col = i;
                while (col < matrix.GetLength(0))
                {
                    matrix[row, col] = counter++;
                    row++;
                    col++;
                }
            }

            PrintArray(matrix);

            //Matrix 4
            counter = 1;
            int r = 0;
            int c = 0;
            while (counter < n*n)
            {
                for (int i = r; i < n - 1 - c; i++)
                {
                    r = i;
                    matrix[i, c] = counter++;
                }
                r++;
                for (int i = c; i < r; i++)
                {
                    c = i;
                    matrix[r, i] = counter++;
                }
                c++;
                for (int i = r; i > n - c - 1; i--)
                {
                    r = i;
                    matrix[i, c] = counter++;
                }
                r--;
                for (int i = c; i > r; i--)
                {
                    c = i;
                    matrix[r, i] = counter++;
                }
                r++;
            }

            if (counter == n*n)
            {
                matrix[n / 2, n / 2] = counter;
            }

            PrintArray(matrix);
        }
    }
}
