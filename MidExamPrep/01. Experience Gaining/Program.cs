using System;

namespace _01._Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal expNeeded = decimal.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine())
;           
            decimal gainedXp = 0m;
            int countOfBattles = 0;

            for (int i = 0; i < battleCount; i++)
            {
                if (gainedXp >= expNeeded)
                {   
                    break;
                }
                decimal expPerBattle = decimal.Parse(Console.ReadLine());
                countOfBattles++;
                if (countOfBattles % 3 == 0)
                {
                    expPerBattle *= 1.15m;

                }
                else if (countOfBattles % 5 == 0)
                {
                    expPerBattle *= 0.90m;
                }
                else if (countOfBattles % 15 == 0)
                {
                    expPerBattle *= 1.05m;
                }
                gainedXp += expPerBattle;
            }
            if (gainedXp >= expNeeded)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {countOfBattles} battles.");
            }
            else
            {
                decimal neededXP = expNeeded - gainedXp;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededXP:f2} more needed.");
            }
             
                
            
        }
    }
}
