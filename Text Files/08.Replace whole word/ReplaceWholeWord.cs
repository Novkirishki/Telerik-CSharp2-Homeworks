using System;
using System.IO;
using System.Text.RegularExpressions;

//Modify the solution of the previous problem to replace only whole words (not strings).

namespace _08.Replace_whole_word
{
    class ReplaceWholeWord
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
                        line = Regex.Replace(line, @"\bstart\b", "finish");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
