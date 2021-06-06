using Abstract_Factory.Continents;
using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine($"List of continents:\n 1.Asia\n 2.Europe\n 3.America\n 4.Africa\n");
            Console.Write("Choose your continent:");
            string option = Console.ReadLine();
            IContinent continent = null;
            IAnimal[] animal = null;
            switch (option)
            {
                case "1":

                    {
                        continent = new Asia();
                    }
                    break;
                case "2":

                    {
                        continent = new Europe();
                    }
                    break;
                case "3":

                    {
                        continent = new America();
                    }
                    break;
                case "4":

                    {
                        continent = new Africa();   
                    }
                    break;
            }
            Console.Clear();
            animal = continent.CreateAnimal();
            int count = animal.Length;
            Console.WriteLine($"Animals living in this continent\n");
            for(int i = 0; i < count; i++)
            {
                animal[i].Eat();
                Console.WriteLine();
                animal[i].Walk();
                Console.WriteLine();
                Console.ReadLine();
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
