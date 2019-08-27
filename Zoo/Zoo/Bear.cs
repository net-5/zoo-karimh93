using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Bear:Animals
    {

        public Bear(string name,Food food):base(name,food)
        {
                
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} likes to eat {Food}.");
        }
    }
}
