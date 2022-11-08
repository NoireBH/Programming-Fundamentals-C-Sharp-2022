using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individualStandings = new Dictionary<string, Dictionary<string, int>>();
            string input;

            while ((input = Console.ReadLine())!= "no more time")
            {
                string[] data = input.Split(" -> ");
                string userName = data[0];
                string contest = data[1];
                int points = int.Parse(data[2]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest].ContainsKey(userName))
                    {
                        if (contests[contest][userName] < points)
                        {
                            contests[contest][userName] = points;
                        }

                        
                    }
                    else
                    {
                        contests[contest].Add(userName, points);
                    }
                }

                else
                {
                   contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(userName, points);
                }

                if (individualStandings.ContainsKey(userName))
                {
                    if (individualStandings[userName].ContainsKey(contest))
                    {
                        if (individualStandings[userName][contest] < points)
                        {
                            individualStandings[userName][contest] = points;
                        }
                    }
                    else
                    {
                        individualStandings[userName].Add(contest, points);
                    }
                }
                else
                {
                    individualStandings.Add(userName, new Dictionary<string, int>());
                    individualStandings[userName].Add(contest, points);
                }

            }
                      
            int position = 1;
            foreach (var item in contests) 
            {
                position = 1;
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");

                foreach (var items in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) 
                {
                    Console.WriteLine($"{position}. {items.Key} <::> {items.Value}");
                    position++;
                }
            }

            var orderedIndividualStanding = new Dictionary<string, int>();
            int sum = 0;

            foreach (var item in individualStandings)
            {
                foreach (var items in item.Value)
                {
                    sum += items.Value;
                }

                orderedIndividualStanding.Add(item.Key, sum);
                sum = 0;
            }

            orderedIndividualStanding = orderedIndividualStanding.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            position = 1;
            Console.WriteLine("Individual standings:");

            foreach (var item in orderedIndividualStanding)
            {
                Console.WriteLine($"{position}. {item.Key} -> {item.Value}");
                position++;
            }
        }

        }
    }

