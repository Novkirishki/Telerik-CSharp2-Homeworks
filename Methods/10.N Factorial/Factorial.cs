using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].

namespace _10.N_Factorial
{
    class Factorial
    {
        static void CalculateFactorials()
        {
            BigInteger[] arr = new BigInteger[100]; 
            for (int i = 0; i < 100; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 1; i < 100; i++)
            {
                arr[i] = (i + 1) * arr[i - 1];
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}! = {1}", i + 1, arr[i]);
            }
        }
        static void Main()
        {
            CalculateFactorials();
        }
    }
}
