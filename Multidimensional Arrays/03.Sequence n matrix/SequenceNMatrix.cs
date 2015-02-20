using System;

//*	We are given a matrix of strings of size `N x M`. Sequences in the matrix we
//define as sets of several neighbour elements located on the same line, column or diagonal.
//*	Write a program that finds the longest sequence of equal strings in the matrix.

namespace _03.Sequence_n_matrix
{
    class SequenceNMatrix
    {
        static void InsertArray(string[,] arr)
        {
            Console.WriteLine("Incert the array row by row: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                string[] row = line.Split(' ');
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = row[j];
                }
            }
        }

        static void FindMaxSequence(string[,] arr)
        {
            //algorithm
            int counter = 1;
            int maxLenght = 0;
            string word = "";
            int row = 0;
            int col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //row
                    row = i;
                    col = j;
                    while (col <= arr.GetLength(1) - 2 && arr[row, col].Equals(arr[row, col + 1]))
                    {
                        col++;
                        counter++;
                    }
                    if (counter > maxLenght )
                    {
                        maxLenght = counter;
                        word = arr[i, j];
                    }
                    counter = 1;

                    //col
                    row = i;
                    col = j;
                    while (row <= arr.GetLength(0) - 2 && arr[row, col].Equals(arr[row + 1, col]))
                    {
                        row++;
                        counter++;
                    }
                    if (counter > maxLenght)
                    {
                        maxLenght = counter;
                        word = arr[i, j];
                    }
                    counter = 1;

                    //diagonal
                    row = i;
                    col = j;
                    while (col <= arr.GetLength(1) - 2 && row <= arr.GetLength(0) - 2 && arr[row, col].Equals(arr[row + 1, col + 1]))
                    {
                        col++;
                        row++;
                        counter++;
                    }
                    if (counter > maxLenght)
                    {
                        maxLenght = counter;
                        word = arr[i, j];
                    }
                    counter = 1;

                    //diagonal2 
                    row = i;
                    col = j;

                    while (col > 0 && row <= arr.GetLength(0) - 2 && arr[row, col].Equals(arr[row + 1, col - 1]))
                    {
                        col--;
                        row++;
                        counter++;
                    }
                    if (counter > maxLenght)
                    {
                        maxLenght = counter;
                        word = arr[i, j];
                    }
                    counter = 1;
                }
            }

            //output
            for (int i = 0; i < maxLenght - 1; i++)
            {
                Console.Write("{0}, ", word);
            }
            Console.Write("{0}", word);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input m: ");
            int m = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, m];

            InsertArray(arr);
            FindMaxSequence(arr);
        }
    }
}
