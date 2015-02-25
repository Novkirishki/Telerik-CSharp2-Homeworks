using System;
using System.IO;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

namespace _07.Replace_sub_string
{
    class ReplaceSubString
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        line = line.Replace("start", "finish");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
