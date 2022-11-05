using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(" -> ");
                string company = data[0];
                string employee = data[1];


                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees[company] = new List<string>();


                }

                if (!companyEmployees[company].Contains(employee))
                {
                    companyEmployees[company].Add(employee);
                }


            }

            foreach (var company in companyEmployees)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }

            }
        }
    }
}
