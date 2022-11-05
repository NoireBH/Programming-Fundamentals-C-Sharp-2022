using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;

            while ((input = Console.ReadLine()) !="end")
            {
                string[] data = input.Split(" : ");
                string nameOfCourse = data[0];
                string studentName = data[1];

                if (!courses.ContainsKey(nameOfCourse))
                {
                    courses.Add(nameOfCourse, new List<string>());

                }

                courses[nameOfCourse].Add(studentName);
               
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
