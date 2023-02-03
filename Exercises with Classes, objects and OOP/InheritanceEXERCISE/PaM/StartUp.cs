using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoulMaster witch = new SoulMaster("Witch", 69);
            Console.WriteLine(witch.ToString());
        }
    }
}
