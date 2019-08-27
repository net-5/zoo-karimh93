using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Horse:Animals
    {
        public Horse(string name, Food food) : base(name, food)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} likes to eat {Food}.");
        }



    }
}
