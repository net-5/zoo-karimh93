using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Actions
    {
      public string ZooName { get; set; }

        
        public List<Animals> Animals { get; set; }

       

        public animaltype AnimalType { get; set; }

        public Actions(string zooName)
        {
            this.ZooName = zooName;
           
        }

        public void TransferAnimal(Actions destination,Animals animals)
        {
            Console.WriteLine($"The {animals.AnimalType} has been transferred to {destination.ZooName}");
            destination.Animals.Add(animals);
            this.Animals.Remove(animals);
        }

        public void BornAnimal(Animals animals)
        {
            Console.WriteLine($"The {animals.AnimalType} was borned at zoo {this.ZooName}");
            Animals.Add(animals);
        }


    }

}



