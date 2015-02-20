using System;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace _13.Solve_tasks
{
    class SolveTasks
    {
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1.Reverse a number ");
                Console.WriteLine("2.Calculate average of a sequence of integers");
                Console.WriteLine("3.Solve a linear equation a * x + b = 0");
                Console.WriteLine("4.Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input a number to be reversed: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(Reverse(n));
                        break;
                    case 2:
                        Console.WriteLine("Input the size of the sequence:");
                        int size = int.Parse(Console.ReadLine());
                        int[] arr = new int[size];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write("number[{0}] =", i);
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine(Average(arr));
                        break;
                    case 3:
                        Console.WriteLine("Input a: ");
                        double a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input b: ");
                        double b = int.Parse(Console.ReadLine());
                        Console.WriteLine("x = {0}", Solve(a, b));
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        static int Reverse(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("The number should be non-negative!");
                return 0;
            }

            string reversed = "";

            while (number > 0)
            {
                reversed += (number % 10).ToString();
                number /= 10;
            }

            return int.Parse(reversed);
        }

        static double Average(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return (double)sum / arr.Length;
        }

        static double Solve(double a, double b)
        {
            return (double)-b / a;
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
