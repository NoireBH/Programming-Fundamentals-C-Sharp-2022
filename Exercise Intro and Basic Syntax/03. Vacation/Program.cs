using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleOnVacaytion =int.Parse(Console.ReadLine());
            string typeOfGroup =Console.ReadLine(); 
            string day = Console.ReadLine();
            double singlePrice = 0;

            switch (day)
            {
                case "Friday":
                    if (typeOfGroup == "Students")
                    {
                        singlePrice = 8.45;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        singlePrice = 10.90;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        singlePrice = 15;
                    }
                    break;
                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        singlePrice = 9.80;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        singlePrice = 15.60;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        singlePrice = 20;
                    }
                   
                    break;
                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        singlePrice = 10.46;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        singlePrice = 16;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        singlePrice = 22.50;
                    }


               
                    break;
            }       
            double totalPrice = peopleOnVacaytion * 1.0 * singlePrice;
            if (typeOfGroup == "Students" && peopleOnVacaytion >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (typeOfGroup == "Business" && peopleOnVacaytion >= 100)
            {
                totalPrice = totalPrice - singlePrice * 10;
            }
            else if (typeOfGroup == "Regular" && peopleOnVacaytion >= 10 && peopleOnVacaytion <= 20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
