using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] internetLinks = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isNumber = true;
                string currentNumber = numbers[i];
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (char.IsDigit(currentNumber[j]))
                    {
                        isNumber = true;
                    }
                    else
                    {
                        isNumber = false;
                    }
                }
                if (!isNumber)
                {
                    Console.WriteLine("Invalid number!");
                }
                ICallable currentPhone;
                if(currentNumber.Length == 10)
                {
                    currentPhone = new Smartphone();
                }
                else
                {
                    currentPhone = new StationaryPhone();
                }
                Console.WriteLine(currentPhone.Call(currentNumber));
            }
            foreach (var link in internetLinks)
            {
                if (link.Any(c => char.IsDigit(c)))
                {
                    Console.WriteLine($"Invalid URL!");
                    continue;
                }
                IBrowsable smartphone = new Smartphone();
                Console.WriteLine(smartphone.Browse(link));
                
            }
        }
    }
}
