using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

namespace _03.Line_numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    string line = reader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        line = counter + " " + line;
                        writer.WriteLine(line);
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
