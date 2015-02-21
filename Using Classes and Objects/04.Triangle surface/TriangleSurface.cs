using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

namespace _04.Triangle_surface
{
    class TriangleSurface
    {
        static void Area1(double side, double altitude)
        {
            Console.WriteLine("The area is {0}", 0.5 * side * altitude);
        }
        static void Area2(double a, double b, double c)
        {
            double p = 0.5 * (a + b + c);
            Console.WriteLine("The area is {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        static void Area3(double a, double b, double angle)
        {
            double angleInRadians = Math.PI * (angle / 180);
            Console.WriteLine("The area is {0}", 0.5 * a * b * Math.Sin(angleInRadians));
        }
        static void Main(string[] args)
        {
            Area1(10, 5);
            Area2(10, 13, 17);
            Area3(4, 4, 30);
        }
    }
}
