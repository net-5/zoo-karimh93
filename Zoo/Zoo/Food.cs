using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Food : Animals
    {

        public Food(animaltype animalType) : base(animalType)
        {
            this.AnimalType = animalType;


        }

        public void Eat()
        {
            if (AnimalType == animaltype.lion)
            {
                Console.WriteLine("Lion eats meat");
            }
            if (AnimalType == animaltype.elephant)
            {
                Console.WriteLine("Elephant eats grass");
            }
            if (AnimalType == animaltype.giraffe)
            {
                Console.WriteLine("Giraffe eats leaves");
            }
            if (AnimalType == animaltype.rabbit)
            {
                Console.WriteLine("Rabbit eats carrots");
            }
            if (AnimalType == animaltype.horse)
            {
                Console.WriteLine("Horse eats apples");
            }
        }



    }
}
