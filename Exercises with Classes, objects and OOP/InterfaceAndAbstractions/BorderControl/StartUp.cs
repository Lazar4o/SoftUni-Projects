using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IId> visiotorsId = new List<IId>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                IId entity;
                if (commandArgs.Length == 2)
                {
                    string robotModel = commandArgs[0];
                    string identificationNumber = commandArgs[1];
                    entity = new Robot(robotModel, identificationNumber);
                    visiotorsId.Add(entity);

                }
                else if (commandArgs.Length == 3)
                {
                    string personName = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string identificationNumber = commandArgs[2];
                    entity = new Citizen(personName, age, identificationNumber);
                    visiotorsId.Add(entity);
                }
            }
            string fakeDigits = Console.ReadLine();
            foreach (var visitor in visiotorsId)
            {
                bool checkValidation = IsValid(visitor.Id, fakeDigits);
                if (checkValidation)
                {
                    Console.WriteLine(visitor.Id);
                }
            }
        }
        public static bool IsValid(string visitorId, string fakeDigits)
        {
            //bool isIdValid = true;
            for (int i = 0; i < fakeDigits.Length; i++)
            {
                if (visitorId[visitorId.Length - 1 - i] != fakeDigits[fakeDigits.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
