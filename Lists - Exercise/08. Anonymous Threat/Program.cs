using System;
using System.Linq;
using System.Collections.Generic;
namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                               .Split()
                              .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];
                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);
                }
            }

        }
    }
}
