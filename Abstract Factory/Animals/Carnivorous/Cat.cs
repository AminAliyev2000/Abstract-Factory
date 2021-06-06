using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Animals.Carnivorous
{
    public class Cat:ICarnivorous
    {
        public Cat()
        {
            Spiece = "Cat";
            Meal = "Meat flakes";
            Speed = 20;
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
