using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Animals.Carnivorous
{
    public class Chita:ICarnivorous
    {
        public Chita()
        {
            Spiece = "Chita";
            Meal = "Meat";
            Speed = 60;
        }
        public string Spiece { get; set; }
        public int Speed { get; set; }
        public string Meal { get; set; }

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
