using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

namespace _04.Appearance_count
{
    class AppearanceCount
    {
        static int AppearanceCounts(double[] arr, double number)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            double[] arr = new double[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Input a number to be searched: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is found {0} times in the array.", AppearanceCounts(arr,number));
        }
    }
}
