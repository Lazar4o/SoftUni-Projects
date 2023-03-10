using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private new const double DefaultFuelConsumption = 8;
        public RaceMotorcycle(int horsepower, double fuel) 
            : base(horsepower, fuel)
        {
            //FuelConsumption = DefaultFuelConsumption;
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
