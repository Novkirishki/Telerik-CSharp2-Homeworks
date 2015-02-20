using System;

//Write a program that reads two numbers N and K and generates all the variations
//of K elements from the set [1..N].

namespace _20.Variations_of_set
{
    class VariationsOfSet
    {
        static void Variations(int[] arr, int k, int[] var)
        {
            if (k > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int[] varCopy = (int[]) var.Clone();
                    varCopy[var.Length - k] = arr[i];
                    Variations(arr, k - 1, varCopy);
                }
            }
            else
            {
                for (int i = 0; i < var.Length; i++)
                {
                    Console.Write("{0} ", var[i]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input k:");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] var = new int[k];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            Variations(arr, k, var);
        }
    }
}
