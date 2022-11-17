using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var piecesAndComposers = new Dictionary<string, Dictionary<string, string>>();
            int numberOfPieces = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieces = Console.ReadLine()
                    .Split('|');
                string piece = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

                piecesAndComposers.Add(piece, new Dictionary<string, string>());
                piecesAndComposers[piece].Add(composer, key);
            }
            string input;

            while ((input = Console.ReadLine())!= "Stop")
            {
                string[] cmd = input
                    .Split("|");
                string command = cmd[0];
                string piece = cmd[1];

                if (command == "Add")
                {
                    string composer = cmd[2];
                    string key = cmd[3];
                    if (!piecesAndComposers.ContainsKey(piece))
                    {
                        piecesAndComposers.Add(piece, new Dictionary<string, string>());
                        piecesAndComposers[piece].Add(composer, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }                  
                }

                else if (command == "Remove")
                {
                    if (piecesAndComposers.ContainsKey(piece))
                    {
                        piecesAndComposers.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                else if (command == "ChangeKey")
                { 
                    string newKey = cmd[2];
                    if (piecesAndComposers.ContainsKey(piece))
                    {
                        var thisComposer = piecesAndComposers[piece].Keys.First();
                        piecesAndComposers[piece][thisComposer] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var item in piecesAndComposers)
            {
                string composer = item.Value.FirstOrDefault().Key;
                string key = item.Value.FirstOrDefault().Value;
                Console.WriteLine($"{item.Key} -> Composer: {composer}, Key: {key}");
            }
        }
    }
}
