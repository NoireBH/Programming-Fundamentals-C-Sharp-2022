using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int firstEmployeeStudents = int.Parse(Console.ReadLine());
            int secondEmployeeStudents = int.Parse(Console.ReadLine());    // per hour
            int thirdEmployeeStudents = int.Parse(Console.ReadLine());
            int employeeEfficiency = (firstEmployeeStudents + secondEmployeeStudents + thirdEmployeeStudents);
            int students = int.Parse(Console.ReadLine());
            int hours = 0;

            while (students > 0)
            {   
                students -= employeeEfficiency;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
