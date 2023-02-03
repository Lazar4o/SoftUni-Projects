using System;
using System.Drawing;

namespace Cars
{
    public class StartUp
    {
        public Random rnd = new Random();

        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
            ChangeCarColor(tesla);
            Console.WriteLine(tesla.Color);
        }
        static void ChangeCarColor(ICar car)
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            car.Color = randomColor.Name;
            //Random randonGen = new Random();
            //Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            //randonGen.Next(255));
            //car.Color = randomColor.Name;
        }
    }
}
