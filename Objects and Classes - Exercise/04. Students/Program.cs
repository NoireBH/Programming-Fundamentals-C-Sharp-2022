using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] data = Console.ReadLine()
                    .Split();
                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);
                Student student = new Student(firstName, lastName , grade);
                students.Add(student);
            }
            foreach (Student student in students.OrderByDescending(X => X.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        class Student
        {
           public Student(string firstName, string lastName , double grade )
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

        }
    }
}
