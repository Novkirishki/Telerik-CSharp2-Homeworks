using System;

//*	Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element `arr[i]` contains a digit; the last digit is kept in `arr[0]`).
//*	Each of the numbers that will be added could have up to `10 000` digits.

namespace _08.Number_as_array
{
    class NumberAsArray
    {
        static long Add(int[] arr1, int[] arr2)
        {
            long a = 0;
            long b = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                a = a + arr1[i] * (long) Math.Pow(10,i);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                b = b + arr2[i] * (long) Math.Pow(10, i);
            }

            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of digits of the first number: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Input the number of digits of the second number: ");
            int m = int.Parse(Console.ReadLine());

            int[] arr2 = new int[m];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            Console.WriteLine("The sum is: {0}", Add(arr1,arr2));
        }
    }
}
