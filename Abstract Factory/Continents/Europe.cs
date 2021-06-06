using Abstract_Factory.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Continents
{
    public class Europe:IContinent
    {
        public IAnimal[] CreateAnimal()
        {
            return new IAnimal[] { new Duck(), new Hen() };

        }
    }
}
