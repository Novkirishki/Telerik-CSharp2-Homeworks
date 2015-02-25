using System;
using System.IO;
using System.Text;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

namespace _09.Delete_odd_lines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                int counter = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 != 1)
                    {
                        builder.AppendLine(line);
                    }
                    line = reader.ReadLine();
                    counter++;
                }
            }

            File.WriteAllText("result.txt", builder.ToString());
        }
    }
}
