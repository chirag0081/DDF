using System;
using System.IO;

namespace DDF
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Users\chira\source\repos\DDF\ScanFiles");
            foreach (var item in filePaths)
            {
                Console.WriteLine(item);
            }
        }
    }
}
