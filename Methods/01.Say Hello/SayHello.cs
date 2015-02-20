using System;

//*	Write a method that asks the user for his name and prints `?Hello, <name>?`
//*	Write a program to test this method.

namespace _01.Say_Hello
{
    class SayHello
    {
        static void Hello()
        {
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            Hello();
        }
    }
}
