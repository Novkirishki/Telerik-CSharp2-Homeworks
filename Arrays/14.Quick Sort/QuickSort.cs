using System;

//Write a program that sorts an array of strings using the Quick sort algorithm.

namespace _14.Quick_Sort
{
    class QuickSort
    {
        static public void Quick(string[] array, int left, int right)
        {
            int curLeft = left;
            int curRight = right;
            if (right > left)
            {
                string pivot = array[(left + right) / 2];

                while (true)
                {


                    while (array[left].CompareTo(pivot) < 0)
                    {
                        left++;
                    }

                    while (array[right].CompareTo(pivot) > 0)
                    {
                        right--;
                    }

                    if (array[right].CompareTo(pivot) == 0 && array[left].CompareTo(pivot) == 0)
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
                        if (right > 1)
                        {
                            Quick(array, curLeft, right - 1);
                        }

                        if (right + 1 < curRight)
                        {
                            Quick(array, right + 1, curRight);
                        }
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Console.ReadLine();
            }

            Quick(arr, 0, size - 1);


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
