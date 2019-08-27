using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant:Animals
    {
        public Elephant(string name, Food food) : base(name, food)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} likes to eat {Food}.");
        }




    }
}
