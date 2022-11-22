using System;
using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordCombination = Console.ReadLine();
            StringBuilder strBuild = new StringBuilder();
            StringBuilder newStrBuild = new StringBuilder();
            strBuild.Append(wordCombination);

            string input;
            while ((input = Console.ReadLine())!="Done")
            {
                string[] cmd = input.Split(" ");
                string command = cmd[0];
                if (command == "TakeOdd")
                {
                    
                    for (int i = 1; i < strBuild.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newStrBuild.Append(strBuild[i]);
                            
                        }
                    }
                    strBuild = newStrBuild;
                    Console.WriteLine(strBuild);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(cmd[1]);
                    int lenght = int.Parse(cmd[2]);                 
                    strBuild.Remove(index, lenght);
                    Console.WriteLine(strBuild);
                }
                else if (command == "Substitute")
                {
                    string substring = cmd[1];
                    string substitude = cmd[2];
                    string stringBuildToString = strBuild.ToString();
                    if (stringBuildToString.Contains(substring))
                    {
                        strBuild.Replace(substring, substitude);
                        Console.WriteLine(strBuild);
                    }

                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }              
                    
                }
            }

            Console.WriteLine($"Your password is: {strBuild}");

        }
    }
}
