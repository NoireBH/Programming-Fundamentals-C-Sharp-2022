using System;
using System.Text;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {           
                StringBuilder stops = new StringBuilder(Console.ReadLine());
                string input;

                while ((input = Console.ReadLine()) != "Travel")
                {
                    string[] cmd = input.Split(":");
                    string command = cmd[0];

                    if (command == "Add Stop")
                    {
                        int index = int.Parse(cmd[1]);
                        string str = cmd[2];

                        if (index >= 0 && index <= stops.Length - 1)
                        {
                            stops.Insert(index, str);

                        }
                        Console.WriteLine(stops);
                    }

                    else if (command == "Remove Stop")
                    {
                        int startIndex = int.Parse(cmd[1]);
                        int endIndex = int.Parse(cmd[2]);

                        if (startIndex >= 0 && endIndex <= stops.Length - 1)
                        {
                            stops.Remove(startIndex, endIndex - startIndex + 1);

                        }
                        Console.WriteLine(stops);
                    }

                    else if (command == "Switch")
                    {
                        string oldString = cmd[1];
                        string newString = cmd[2];

                        if (stops.ToString().Contains(oldString))
                        {
                            stops.Replace(oldString, newString);

                        }
                        Console.WriteLine(stops);
                    }
                }

                Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
            }
        }
    }

