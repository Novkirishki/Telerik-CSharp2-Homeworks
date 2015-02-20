using System;

//You are given an array of strings. Write a method that sorts the array by the
//length of its elements (the number of characters composing them).

namespace _05.Sort_by_string_length
{
    class SortByStringLength
    {
        static public void QuickSortByLength(string[] array, int left, int right)
        {
            int curLeft = left;
            int curRight = right;
            if (right > left)
            {
                string pivot = array[(left + right) / 2];

                while (true)
                {
                    while (array[left].Length < pivot.Length)
                    {
                        left++;
                    }

                    while (array[right].Length > pivot.Length)
                    {
                        right--;
                    }

                    if (array[right].Length == pivot.Length && array[left].Length == pivot.Length)
                    {
                        left++;
                    }

                    if (left < right)
                    {
                        string buf = array[right];
                        array[right] = array[left];
                        array[left] = buf;
                    }
                    else
                    {
                        break;
                    }
                }

                if (right > 1)
                {
                    QuickSortByLength(array, curLeft, right - 1);
                }

                if (right + 1 < curRight)
                {
                    QuickSortByLength(array, right + 1, curRight);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Console.ReadLine();
            }

            QuickSortByLength(arr, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
