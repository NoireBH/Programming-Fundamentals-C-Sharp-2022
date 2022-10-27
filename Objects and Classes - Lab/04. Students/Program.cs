using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;

            while ((input = Console.ReadLine())!= "end")
            {
                string[] data = input.Split(" ");
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown

                };

                students.Add(student);

            }
            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
        class Student
        {
          

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }



        }
    }
}
