using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public enum Food
    {
        Meat,
        Grass,
        Carrots,
        Apples,
        Leaves,
        Fish

    }

    public abstract class Animals
    {

        private string name;

        private Food food;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;
            }
        }

        public Food Food
        {
            get
            {
                return food;
            }
            set
            {

                food = value;
            }
        }


        public Animals(string name, Food food)
        {
            Name = name;
            Food = food;
        }


        public virtual void Eat()
        {
            Console.WriteLine($"{Name} likes to eat {Food}.");
        }

        public string Info()
        {
            return($"Name: {Name} , Favourite food: {Food}");
        }

    }
}

