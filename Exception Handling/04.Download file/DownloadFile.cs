using System;
using System.Net;

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

namespace _04.Download_file
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(@"http://img-9gag-ftw.9cache.com/photo/anKjVjo_700b.jpg", "picture.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught - {0}", e.Message);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
