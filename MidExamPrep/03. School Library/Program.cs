using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shelfWithBooks
                = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine())!= "Done")
            {
                string[] cmd = input.Split(" | ");
                string command = cmd[0];    

                if (command == "Add Book")
                {   string bookName = cmd[1];
                    if (shelfWithBooks.Contains(bookName))
                    {
                        continue;
                    }
                    else
                    {
                        shelfWithBooks.Insert(0, bookName);
                    }
                }
                else if (command == "Take Book")
                {
                    string bookName = cmd[1];
                    if (shelfWithBooks.Contains(bookName))
                    {
                        shelfWithBooks.Remove(bookName);
                    }

                }
                else if (command == "Swap Books")
                {
                    string book1 = cmd[1];
                    string book2 = cmd[2];
                    if (shelfWithBooks.Contains(book1) && shelfWithBooks.Contains(book2))
                    {
                        for (int i = 0; i < shelfWithBooks.Count; i++)
                        {
                            if (shelfWithBooks[i] == book1)
                            {
                                shelfWithBooks[i] = book2;

                            }
                            else if (shelfWithBooks[i] == book2)
                            {
                                shelfWithBooks[i] = book1;
                            }

                        }
                    }
                }
                else if (command == "Insert Book")
                {
                    string bookName = cmd[1];
                    if (shelfWithBooks.Contains(bookName))
                    {
                        continue;
                    }
                    else
                    {
                        shelfWithBooks.Add(bookName);
                    }

                }
                else if (command == "Check Book")
                {
                    int index = int.Parse(cmd[1]);
                    if (index >= 0 && index <= shelfWithBooks.Count - 1)
                    {
                        Console.WriteLine($"{shelfWithBooks[index]}");
                    }

                }
            }
            Console.WriteLine(String.Join(", ", shelfWithBooks));
        }
    }
}
