using System;

//Extend the previous program to support also subtraction and multiplication of polynomials.

namespace _12.Subtracting_polynomials
{
    class SubtractingPolynomials
    {
        //Adding
        static double[] Add(double[] poly1, double[] poly2)
        {
            int bigSize = 0;
            int smallSize = 0;

            if (poly1.Length < poly2.Length)
            {
                bigSize = poly2.Length;
                smallSize = poly1.Length;
            }
            else
            {
                bigSize = poly1.Length;
                smallSize = poly2.Length;
            }

            double[] result = new double[bigSize];

            for (int i = 0; i < smallSize; i++)
            {
                result[i] = poly1[i] + poly2[i];
            }

            while (smallSize < poly1.Length)
            {
                result[smallSize] = poly1[smallSize];
                smallSize++;
            }

            while (smallSize < poly2.Length)
            {
                result[smallSize] = poly2[smallSize];
                smallSize++;
            }

            return result;
        }

        //Substracting
        static double[] Substract(double[] poly1, double[] poly2)
        {
            int bigSize = 0;
            int smallSize = 0;

            if (poly1.Length < poly2.Length)
            {
                bigSize = poly2.Length;
                smallSize = poly1.Length;
            }
            else
            {
                bigSize = poly1.Length;
                smallSize = poly2.Length;
            }

            double[] result = new double[bigSize];

            for (int i = 0; i < smallSize; i++)
            {
                result[i] = poly1[i] - poly2[i];
            }

            while (smallSize < poly1.Length)
            {
                result[smallSize] = poly1[smallSize];
                smallSize++;
            }

            while (smallSize < poly2.Length)
            {
                result[smallSize] = poly2[smallSize];
                smallSize++;
            }

            return result;
        }

        //Multiplication
        static double[] Multiply(double[] poly1, double[] poly2)
        {
            double[] result = new double[poly1.Length + poly2.Length - 1];

            for (int i = 0; i < poly1.Length; i++)
            {
                for (int j = 0; j < poly2.Length; j++)
                {
                    result[i + j] = result[i + j] + poly1[i] * poly2[j];
                }
            }

            return result;
        }
        static void toString(double[] arr)
        {
            Console.Write("{{{0}", arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(", {0}", arr[i]);
            }
            Console.WriteLine("}");
        }
        static void Main(string[] args)
        {
            double[] poly1 = { 1, 4, 7 };
            double[] poly2 = { 1, 3 };
            toString(Add(poly1, poly2));
            toString(Substract(poly1, poly2));
            toString(Multiply(poly1, poly2));
        }
    }
}
