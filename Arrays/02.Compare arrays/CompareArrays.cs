using System;

//Write a program that reads two integer arrays from the console and compares them element by element.

namespace _02.Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incert the size of the arrays: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            bool flag = true;

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr1[{0}] = ",i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr2[{0}] = ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    flag = false;
                    break;
                }
            }

            Console.WriteLine("Are the arrays equal - {0}", flag);
        }
    }
}
