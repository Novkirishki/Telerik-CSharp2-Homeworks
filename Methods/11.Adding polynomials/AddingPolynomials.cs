using System;

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

namespace _11.Adding_polynomials
{
    class AddingPolynomials
    {
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

        static void toString(double[] arr)
        {
            Console.Write("{{{0}", arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(", {0}",arr[i]);
            }
            Console.WriteLine("}");
        }
        static void Main(string[] args)
        {
            double[] poly1 = {1, 4, 7};
            double[] poly2 = {1, 3};
            toString(Add(poly1,poly2));
        }
    }
}
