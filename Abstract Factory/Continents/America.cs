using Abstract_Factory.Animals.Carnivorous;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Continents
{
    public class America:IContinent
    {
        public IAnimal[] CreateAnimal()
        {
            return new IAnimal[] { new Cat(), new AnotherAnimal() };

        }
    }
}
