using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

namespace _02.Concatenate_text_files
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"text1.txt");
            text += File.ReadAllText(@"text2.txt");

            File.WriteAllText(@"result.txt", text);
        }
    }
}
