using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            Team team = new Team("Greek Gods");
            var zeus = new Person("Zeus", "Thunderlord", 3000, 666666);
            var ivan = new Person("Ivan", "The Cruel", 1367, 120000);
            var jordan = new Person("Jordan", "GayLord", 17, 2500);
            team.AddPlayer(zeus);
            team.AddPlayer(ivan);
            team.AddPlayer(jordan);
            Console.WriteLine("First team: " + team.FirstTeam.Count);
            Console.WriteLine("Reserve team: " + team.ReserveTeam.Count);



        }
    }
}
