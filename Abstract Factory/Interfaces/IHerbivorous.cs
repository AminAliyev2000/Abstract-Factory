using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public interface IHerbivorous:IAnimal
    {
        string Spiece { get; set; }
        string Meal { get; set; }
        int Speed { get; set; }
    }
}
