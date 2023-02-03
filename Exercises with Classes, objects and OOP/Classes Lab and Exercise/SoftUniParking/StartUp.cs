using System;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Tesla", "Model X", 550, "С 3333 С");
            Car car2 = new Car("Audi", "A3", 110, "EB8787MN");
            Car car3 = new Car("Mercedes-Benz", "CLS", 420, "B3838CA");

            Console.WriteLine(car.ToString());
            Parking parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));
            Console.WriteLine(parking.AddCar(car3));


            Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            Console.WriteLine(parking.RemoveCar("EB8787MN"));
            Console.WriteLine(parking.Count);
        }
    }
}
