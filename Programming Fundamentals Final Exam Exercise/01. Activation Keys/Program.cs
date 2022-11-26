using System;
using System.Text;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();
            StringBuilder strKey = new StringBuilder();
            strKey.Append(rawActivationKey);
            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] cmd = input.Split(">>>");
                string command = cmd[0];

                if (command == "Contains")
                {
                    string substring = cmd[1];
                    if (strKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{strKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    int startIndex = int.Parse(cmd[2]);
                    int endIndex = int.Parse(cmd[3]);
                    char[] charOfKey = rawActivationKey.ToCharArray();
                    
                    if (cmd[1] == "Upper")
                    {   
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            
                          char result =  char.ToUpper(charOfKey[i]);
                            strKey[i] = result;
                            rawActivationKey = strKey.ToString();
                        }

                    }

                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {

                            char result = char.ToLower(charOfKey[i]);
                            strKey[i] = result;
                            rawActivationKey = strKey.ToString();
                        }
                    }
                    
                    Console.WriteLine(rawActivationKey);
                }

                else if (command == "Slice")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                                     
                        strKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey = strKey.ToString();
                    Console.WriteLine(rawActivationKey);
                    
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
