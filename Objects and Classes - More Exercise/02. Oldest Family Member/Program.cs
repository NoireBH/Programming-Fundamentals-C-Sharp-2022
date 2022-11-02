using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family familyMembers = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {   
                string[] data = Console.ReadLine()
                    .Split(' ');
                string nameOfPerson = data[0];
                int age = int.Parse(data[1]);
                Person person = new Person(nameOfPerson , age);

                familyMembers.AddMember(person);
               

            }
            Person oldestMember = familyMembers.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        public class Family
        {
            List<Person> People { get; set; }
            public Family()
            {
                People = new List<Person>();
            }

            public void AddMember(Person member)
            {
                
                People.Add(member);
            }

            public Person GetOldestMember()
            {
                return People.OrderByDescending(x => x.Age).FirstOrDefault();
            }

            
        }


    }
}
