using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public new const double DefaultFuelConsumption = 10;
        public SportCar(int horsepower, double fuel)
            : base(horsepower, fuel)
        {

        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}

