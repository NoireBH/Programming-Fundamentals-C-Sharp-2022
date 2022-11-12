using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pathFile = Console.ReadLine()
                .Split("\\");
            string file = pathFile[pathFile.Length - 1];
            string[] splitFileAndExtension = file
                .Split('.');
            string fileName = splitFileAndExtension[0];
            string extension = splitFileAndExtension[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
            
            
        }
    }
}
