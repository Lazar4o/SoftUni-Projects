using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothesSize = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackSize = int.Parse(Console.ReadLine());
            int sumClotes = 0;
            int numOfRacks = 0;
            while (clothesSize.Count != 0)
            {
                int currentCloth = clothesSize.Peek();
                if (sumClotes + currentCloth <= rackSize)
                {
                    sumClotes += currentCloth;
                    clothesSize.Pop();
                }
                else 
                {
                    sumClotes = 0;
                    numOfRacks++;
                }
            }
            numOfRacks++;
            Console.WriteLine(numOfRacks);
        }
    }
}
