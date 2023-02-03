using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while (command != "No more tires")
            {
                List<string> commandArgs = command.Split().ToList();
                Tire[] currentTiresArray = new Tire[4];
                for (int i = 0; i < 4; i++)
                {
                    Tire currentTires = new Tire(int.Parse(commandArgs[0]), double.Parse(commandArgs[1]));
                    currentTiresArray[i] = currentTires;
                    commandArgs.RemoveAt(0);
                    commandArgs.RemoveAt(0);
                }
                tires.Add(currentTiresArray);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "Engines done")
            {
                string[] commandArgs = command.Split();
                Engine currentEngines = new Engine(int.Parse(commandArgs[0]), double.Parse(commandArgs[1]));
                engines.Add(currentEngines);

                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "Show special")
            {
                List<string> carStats = command.Split().ToList();
                Car currentCar = new Car(carStats[0], carStats[1], int.Parse(carStats[2]),
                    double.Parse(carStats[3]), double.Parse(carStats[4]), 
                    engines[int.Parse(carStats[5])], tires[int.Parse(carStats[6])]);
                cars.Add(currentCar);
                command = Console.ReadLine();
            }
            cars = cars.Where(c =>
            c.Year >= 2017 && c.Engine.HorsePower > 330 &&
            c.Tires.Sum(x => x.Pressure) >= 9 && c.Tires.Sum(x => x.Pressure) <= 10).ToList();
            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
