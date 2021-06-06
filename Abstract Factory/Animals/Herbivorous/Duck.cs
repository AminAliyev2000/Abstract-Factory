using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Animals
{
    public class Duck:IHerbivorous
    {
        public Duck()
        {
            Spiece = "Duck";
            Meal = "Corn";
            Speed = 5;
        }
        public string Spiece { get; set; }
        public string Meal { get; set; }
        public int Speed { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Spiece} eats {Meal} meal");
        }

        public void Walk()
        {
            Console.WriteLine($"{Spiece} walks with speed {Speed} km/h");
        }
    }
}
