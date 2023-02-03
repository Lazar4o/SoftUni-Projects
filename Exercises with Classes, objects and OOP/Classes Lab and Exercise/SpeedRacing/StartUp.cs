using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string model = commandArgs[0];
                double fuelAmount = double.Parse(commandArgs[1]);
                double fuelConsumptionFor1km = double.Parse(commandArgs[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km, 0);
                listOfCars.Add(car);
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string carModel = commandArgs[1];
                double amountOfKm = double.Parse(commandArgs[2]);
                foreach (var item in listOfCars)
                {
                    if (item.Model == carModel)
                    {
                        item.Drive(item, amountOfKm);
                        break;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in listOfCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
