using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ContestAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> student = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine())!= "end of contests")
            {
                string[] data = input.Split(":");
                string contest = data[0];
                string password = data[1];

                if (!ContestAndPassword.ContainsKey(contest))
                {
                    ContestAndPassword.Add(contest, password);
                }

            }

            string input2;

            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] data = input2.Split("=>");
                string contest = data[0];
                string password = data[1];
                string userName = data[2];
                int points = int.Parse(data[3]);

                if (ContestAndPassword.ContainsKey(contest) && ContestAndPassword[contest] == password)
                {
                    if (!student.ContainsKey(userName))
                    {
                        student.Add(userName, new Dictionary<string, int>());
                        student[userName].Add(contest, points);
                    }

                    else
                    {
                        if (!student[userName].ContainsKey(contest))
                        {
                            student[userName].Add(contest, points);
                        }
                        else
                        {
                            if (student[userName][contest] < points)
                            {
                                student[userName][contest] = points;
                            }

                        }
                    }
                }
          
            }

            string bestStudent = "";
            int highPoints = 0;


            foreach (var name in student)
            {
                int totalPoints = 0;
                foreach (var course in name.Value)
                {
                    totalPoints += course.Value;
                }
                if (totalPoints > highPoints)
                {
                    bestStudent = name.Key;
                    highPoints = totalPoints;
                }
            }


            Console.WriteLine($"Best candidate is {bestStudent} with total {highPoints} points.");
            student = student.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine("Ranking:");
            foreach (var name in student)
            {
                Console.WriteLine(name.Key);
                foreach (var course in name.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }

            }

            }
        }
    }

