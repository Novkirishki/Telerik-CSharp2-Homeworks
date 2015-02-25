using System;
using System.IO;
using System.Collections.Generic;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

namespace _06.Save_sorted_names
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            using (StreamReader reader = new StreamReader("file.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }
            }

            string[] arr = list.ToArray();
            Array.Sort(arr);

            File.WriteAllLines("result.txt", arr);
        }
    }
}
