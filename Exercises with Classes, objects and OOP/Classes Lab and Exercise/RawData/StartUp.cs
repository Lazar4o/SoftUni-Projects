using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
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
                int engineSpeed = int.Parse(commandArgs[1]);
                int enginePower = int.Parse(commandArgs[2]);
                int cargoWeight = int.Parse(commandArgs[3]);
                string cargoType = commandArgs[4];

                Engine currentEngine = new Engine(engineSpeed, enginePower);
                Cargo currentCargo = new Cargo(cargoType, cargoWeight);
                Tires[] fullTiresSet = new Tires[4];
                int counter = 0;
                for (int j = 5; j <= 12; j += 2)
                {
                    double tire1Pressure = double.Parse(commandArgs[j]);
                    int tireAge = int.Parse(commandArgs[j + 1]);
                    Tires currentTire = new Tires(tireAge, tire1Pressure);
                    fullTiresSet[counter++] = currentTire;
                }
                Car car = new Car(model, currentEngine, currentCargo, fullTiresSet);
                listOfCars.Add(car);
            }
            string searchCarCargo = Console.ReadLine();
            if (searchCarCargo == "flammable")
            {
                var filteredCars = listOfCars.Where(x => x.Cargo.Type == "flammable");
                foreach (var item in filteredCars)
                {
                    if (item.Engine.Power > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            else if (searchCarCargo == "fragile")
            {
                bool lesserPressure = false;
                var filteredCars = listOfCars.Where(x => x.Cargo.Type == "fragile");
                foreach (var item in filteredCars)
                {
                    foreach (var tires in item.Tires)
                    {
                        if (tires.Pressure < 1)
                        {
                            lesserPressure = true;
                        }
                    }
                    if (lesserPressure)
                    {
                        Console.WriteLine(item.Model);
                        lesserPressure = false;
                    }
                }
            }
        }
    }
}