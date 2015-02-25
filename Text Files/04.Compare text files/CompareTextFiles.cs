using System;
using System.IO;

//Write a program that compares two text files line by line and prints the number 
//of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

namespace _04.Compare_text_files
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            int equal = 0;
            int different = 0;

            using (StreamReader reader1 = new StreamReader("file1.txt"))
            {
                using (StreamReader reader2 = new StreamReader("file2.txt"))
                {
                    string line1 = reader1.ReadLine();
                    string line2 = reader2.ReadLine();
                    while (line1 != null)
                    {
                        if (line1.Equals(line2))
                        {
                            equal++;
                        }
                        else
                        {
                            different++;
                        }

                        line1 = reader1.ReadLine();
                        line2 = reader2.ReadLine();
                    }
                    
                }
            }

            Console.WriteLine("Equal lines - {0}", equal);
            Console.WriteLine("Different lines - {0}", different);
        }
    }
}
