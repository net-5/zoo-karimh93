using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Girrafe:Animals
    {

        public Girrafe(string name, Food food) : base(name, food)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} likes to eat {Food}.");
        }

    }
}
