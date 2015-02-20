using System;

//Write a method `GetMax()` with two parameters that returns the larger of two integers.
//*	Write a program that reads `3` integers from the console and prints the largest of them using the method `GetMax()`.


namespace _02.Get_Largest_Number
{
    class GetLargestNumber
    {
        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input three integers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int ab = GetMax(a, b);
            int bc = GetMax(b, c);
            int abc = GetMax(ab, bc);

            Console.WriteLine("The largest number is: {0}", abc);
        }
    }
}
