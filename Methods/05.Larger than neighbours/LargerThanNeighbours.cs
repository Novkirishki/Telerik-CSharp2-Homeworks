using System;

//Write a method that checks if the element at given position in given array of 
//integers is larger than its two neighbours (when such exist).

using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class LargerThanNeighbours
    {
        static bool IsLargerThanNeighbours(double[] arr, int index)
        {
            if (index == 0 && arr[index] >= arr[index + 1])
            {
                return true;
            }
            if (index == (arr.Length - 1) && arr[index] >= arr[index - 1])
            {
                return true;
            }
            if (arr[index] >= arr[index - 1] && arr[index] >= arr[index + 1])
            {
                return true;
            }
            return false;
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

            Console.WriteLine("Input the position to be checked: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is at position {0}  is larger than its neighbours - {1}", index, IsLargerThanNeighbours(arr, index));
        }
    }
}
