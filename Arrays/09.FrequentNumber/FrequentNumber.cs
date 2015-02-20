using System;

//Write a program that finds the most frequent number in an array.

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 0;
            int currentCounter = 1;
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    currentCounter++;
                }
                else 
                {
                    if (currentCounter > counter)
                    {
                        counter = currentCounter;
                        number = arr[i];
                    }                   
                    currentCounter = 1;                   
                }
            }

            Console.WriteLine("{0} ({1} times)", number, counter);
        }
    }
}
