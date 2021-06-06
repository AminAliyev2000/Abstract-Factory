using Abstract_Factory.Animals.Carnivorous;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Continents
{
    public class Africa : IContinent
    {
        public IAnimal[] CreateAnimal()
        {
            return new IAnimal[] { new Lion(), new Chita() };

        }
    }
}
