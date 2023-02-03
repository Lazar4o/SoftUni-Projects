using System;
using System.Linq;
using System.Collections.Generic;


namespace StudentsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] inputArgs = input.Split('-');
                string username = inputArgs[0];
                string language = inputArgs[1];

                bool doesItContains = results.ContainsKey(username);
                if (language == "banned" && doesItContains)
                {
                    results.Remove(username);
                    input = Console.ReadLine();
                    continue;
                }
                int points = int.Parse(inputArgs[2]);
                int previousPoints = 0;

                if (!results.ContainsKey(username))
                {
                    results.Add(username, points);
                    previousPoints = points;
                }
                else if (results[username] < points)
                {
                    results[username] =  points;
                }
                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 1);
                }
                else
                {
                    submissions[language]++;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            foreach (var (name, points) in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(name + " | " + points);
            }
            Console.WriteLine("Submissions:");
            

            foreach (var (language, count) in submissions.OrderByDescending(c => c.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}
