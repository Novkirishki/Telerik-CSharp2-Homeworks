using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

namespace _03.Compare_char_arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = { 'a', 'r', 'r', '1' };
            char[] arr2 = { 'a', 'r', 'r', '2' };
            bool flag = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    flag = false;
                }
            }

            Console.WriteLine("Are the arrays equal - {0}", flag);

        }
    }
}
