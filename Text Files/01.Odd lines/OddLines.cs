using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

namespace _01.Odd_lines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                int counter = 0;
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}
