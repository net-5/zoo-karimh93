using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public enum animaltype

    {
        horse,
        giraffe,
        rabbit,
        lion,
        elephant

    }
    

    public class Animals
    {

        public animaltype AnimalType { get; set; }

        public Animals(animaltype animalType)
        {

            this.AnimalType = animalType;

        }
    }
}
