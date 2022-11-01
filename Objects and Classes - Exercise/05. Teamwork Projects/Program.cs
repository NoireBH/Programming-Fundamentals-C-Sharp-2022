using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            InitializeTeams(teams);
            JoinTeams(teams);
            PrintValidTeams(teams);
            PrintTeamsToDisband(teams);
        }

        private static void PrintTeamsToDisband(List<Team> teams)
        {
            List<Team> teamsToDisband = teams
                            .Where(X => X.Members.Count == 0)
                                        .OrderBy(X => X.Name)
                                        .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var disbandedTeams in teamsToDisband)
            {
                
                Console.WriteLine($"{disbandedTeams.Name}");
            }
        }

        private static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
                            .Where(X => X.Members.Count > 0)
                            .OrderByDescending(X => X.Members.Count)
                            .ThenBy(X => X.Name)
                            .ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(X => X))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        private static void JoinTeams(List<Team> teams)
        {
            string input;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] data = input.
                    Split("->")
                    .ToArray();
                string user = data[0];
                string teamName = data[1];

                if (!TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams.First(X => X.Name == teamName);
                    teamToJoin.AddMember(user);
                }

            }
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams , string user)
        {
            return teams.Any(X => X.Members.Contains(user)) || 
                teams.Any(X => X.Creator == user);
        }
        private static void InitializeTeams(List<Team> teams)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] data = Console.ReadLine().Split('-');
                string creator = data[0];
                string teamName = data[1];
              


                if (TeamExists(teams , teamName))
                {

                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams , creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }





            }
        }
        static bool TeamExists(List<Team> teams ,string teamName)
        {
            return teams.Any(X => X.Name == teamName);
        }
        static bool AlreadyCreatedATeam(List<Team> teams , string creator)
        {
            return teams.Any(X => X.Creator == creator);
        }

        class Team
        {
            List<string> members;

            public Team(string name , string creator)
            {
                this.Name = name;
                this.Creator = creator;
                this.members = new List<string>();
            }
            
            public string Name { get; set; }
            public string Creator { get; set; }

            


            public List<string> Members
                => members;

            public void AddMember(string member)
            {
                members.Add(member);
            }
            
        }
    }

}
