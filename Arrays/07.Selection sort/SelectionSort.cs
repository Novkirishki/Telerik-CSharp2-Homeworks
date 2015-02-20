using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.

namespace _07.Selection_sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                index = i;
                for (int j = i; j < arr.Length; j++)
                {                    
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        index = j;
                    }
                }
                arr[index] = arr[i];
                arr[i] = min; 
            }

            foreach (int a in arr)
            {
                Console.Write("{0} ",a);
            }



        }
    }
}
