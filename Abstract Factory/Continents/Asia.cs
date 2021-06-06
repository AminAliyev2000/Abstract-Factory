using Abstract_Factory.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Continents
{
    public class Asia:IContinent
    {
        public IAnimal[] CreateAnimal()
        {
            return new IAnimal[] { new Elephant(), new Coala() };

        }
    }
}
