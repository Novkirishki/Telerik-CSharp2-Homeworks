using System;
using System.IO;

//Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03.Read_file_contents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Windows\win.ini"))
                {
                    try
                    {
                        string content = reader.ReadToEnd();
                        Console.WriteLine(content);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Caught error - {0}", e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught error - {0}", e.Message);
            }
        }
    }
}
