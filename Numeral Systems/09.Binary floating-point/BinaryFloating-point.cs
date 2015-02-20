using System;
using System.Collections;

//Write a program that shows the internal binary representation of given 32-bit signed
//floating-point number in IEEE 754 format (the C# type float).

namespace _09.Binary_floating_point
{
    class Program
    {
        static void toBits(float n)
        {
            byte[] arr = BitConverter.GetBytes(n);
            var bits = new BitArray(arr);

            //Sign
            if (bits[31] == false)
            {
                Console.WriteLine("Sign: 0");
            }
            else
            {
                Console.WriteLine("Sign: 1");
            }            

            //Exponent
            Console.Write("Exponent: ");
            for (int i = 30; i > 22; i--)
            {
                if (bits[i] == false)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
            }
            Console.WriteLine();

            //Mantissa
            Console.Write("Mantissa: ");
            for (int i = 22; i > 0; i--)
            {
                if (bits[i] == false)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a float number: ");
            float n = float.Parse(Console.ReadLine());

            toBits(n);
        }
    }
}
