using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] cmd = input.Split(":");
                string command = cmd[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(cmd[1]);
                    string name = cmd[2];
                    if ((index >= 0) && (index < stops.Length))
                    {
                      stops =  stops.Insert(index, name);
                    }
                    Console.WriteLine(stops);
                }
                else if (command == "Remove Stop")
                {
                    int startIdx = int.Parse(cmd[1]);
                    int endIdx = int.Parse(cmd[2]);

                    if (startIdx >= 0 && endIdx < stops.Length)
                    {
                        stops = stops.Remove(startIdx, endIdx - startIdx + 1);
                    }

                    Console.WriteLine(stops);
                }
                else if (command == "Switch")
                {
                    string oldText = cmd[1];
                    string newText = cmd[2];

                    if (stops.Contains(oldText))
                    {
                       stops = stops.Replace(oldText, newText);
                    }

                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }
    }
}
