using System;

//Write a method that returns the index of the first element in array that is 
//larger than its neighbours, or `-1`, if there?s no such element.
//Use the method from the previous exercise.

namespace _06.First_larger_than_neighbours
{
    class FirstLargerThanNeighbours
    {
        static int LargerThanNeighbours(double[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (index == 0 && arr[index] >= arr[index + 1])
                {
                    return index;
                }
                if (index == (arr.Length - 1) && arr[index] >= arr[index - 1])
                {
                    return index;
                }
                if (index > 0 && index < (arr.Length - 1) && arr[index] >= arr[index - 1] && arr[index] >= arr[index + 1])
                {
                    return index;
                }
            }
            return -1;
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

            if (LargerThanNeighbours(arr) != -1)
            {
                Console.WriteLine("The first number larger than its neighbours is at position {0}", LargerThanNeighbours(arr));
            }
            else
            {
                Console.WriteLine("No number is larger than its neighbours");
            }
           
        }
    }
}
