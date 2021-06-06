using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface ICarnivorous:IAnimal
    {
        string Spiece { get; set; }
        int Speed { get; set; }
        string Meal { get; set; }
    }
}
