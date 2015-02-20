using System;

//Write a program that sorts an array of integers using the Merge sort algorithm.

namespace _13.Merge_sort
{
    class MergeSort
    {
        static public void Merge(int[] array, int left, int right)
        {
            if (right > left)
            {


                int mid = (left + right) / 2;

                Merge(array, left, mid);
                Merge(array, mid + 1, right);

                int curLeft = left;
                int curRight = mid + 1;
                int curPosition = 0;
                int[] curArr = new int[right - left + 1];

                while ((curLeft <= mid) && (curRight <= right))
                {
                    if (array[curLeft] <= array[curRight])
                    {
                        curArr[curPosition] = array[curLeft];
                        curPosition++;
                        curLeft++;
                    }
                    else
                    {
                        curArr[curPosition] = array[curRight];
                        curPosition++;
                        curRight++;
                    }
                }

                while (curLeft <= mid)
                {
                    curArr[curPosition] = array[curLeft];
                    curPosition++;
                    curLeft++;
                }

                while (curRight <= right)
                {
                    curArr[curPosition] = array[curRight];
                    curPosition++;
                    curRight++;
                }

                for (int i = right; i >= left; i--)
                {
                    array[i] = curArr[curPosition - 1];
                    curPosition--;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Incert the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Merge(arr, 0, size - 1);


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
