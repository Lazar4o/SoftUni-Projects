using System;
using System.Collections.Generic;
using System.Text;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                string[] commandArgs = Console.ReadLine().Split(" ");
                string action = commandArgs[0];

                for (int i = 1; i < commandArgs.Length; i++) //Building the stringbuilder
                {
                    sb.Append(commandArgs[i] + " ");
                }
                if (sb.Length > 0)
                {
                sb.Remove(sb.Length - 1, 1);
                }
                if (action == "Play")
                {
                    songs.Dequeue();
                }
                else if (action == "Add")
                {
                    if (songs.Contains(sb.ToString()))
                    {
                        Console.WriteLine($"{sb.ToString()} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(sb.ToString());
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
        }
    }
}
