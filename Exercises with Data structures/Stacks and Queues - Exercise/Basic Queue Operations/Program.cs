using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numInQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int numsToDequeue = numCommands[1];
            int numPresented = numCommands[2];
            for (int i = 0; i < numsToDequeue; i++)
            {
                numInQueue.Dequeue();
            }
            if (numInQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                //Console.WriteLine(numInQueue.Contains(numPresented) ? "true" : numInQueue.Min());
                if (numInQueue.Contains(numPresented))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numInQueue.Min());
                }
            }
        }
    }
}
