using System;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

namespace _05.Maximal_area_sum
{
    class MaximalAreaSum
    {
        static int[,] ReadMatrix(string pathToFile)
        {
            int[,] matrix;
            using (StreamReader reader = new StreamReader(pathToFile))
            {
                int size = int.Parse(reader.ReadLine());
                matrix = new int[size, size];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    string line = reader.ReadLine();
                    string[] numbers = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }
            }

            return matrix;
        }

        static int CalculateMax(int[,] matrix)
        {
            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
                currentSum = 0;
            }

            return maxSum;
        }

        static void WriteToFile(string pathToFile, int result)
        {
            File.WriteAllText(pathToFile, result.ToString());
        }
        static void Main(string[] args)
        {
            int result = CalculateMax(ReadMatrix("file.txt"));
            WriteToFile("result.txt", result);
        }
    }
}
