using System;
//Write a program that finds all prime numbers in the range [`1...10 000 000`]. Use the [Sieve of Eratosthenes] algorithm.

namespace _15.Prime_Numbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            bool[] arr = new bool[10000000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    for (int j = 2*i; j < arr.Length; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
