using System;
using System.Linq;

namespace DateModifier
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondDate = Console.ReadLine().Split().Select(int.Parse).ToArray();

            DateTime d1 = new DateTime(firstDate[0], firstDate[1], firstDate[2]);
            DateTime d2 = new DateTime(secondDate[0], secondDate[1], secondDate[2]);

            TimeSpan t = d1 - d2;
            double NrOfDays = t.TotalDays;
            Console.WriteLine(Math.Abs(NrOfDays));
        }
    }
}
