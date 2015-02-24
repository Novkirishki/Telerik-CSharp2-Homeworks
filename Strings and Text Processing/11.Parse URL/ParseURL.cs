using System;

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

namespace _11.Parse_URL
{
    class ParseURL
    {
        static void URLparser(string address)
        {
            int index1 = address.IndexOf("://");
            int index2 = address.IndexOf("/", index1 + 3);
            string protocol = address.Substring(0, index1);
            string server = address.Substring(index1 + 3, index2 - index1 - 3);
            string resource = address.Substring(index2 );

            Console.WriteLine("[protocol] = {0}",protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input URL address:");
            string text = Console.ReadLine();

            URLparser(text);
        }
    }
}
