using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Zoo
    {

        private string zooName;
        public string ZooName { get { return zooName ; } set { zooName = value; } }


        private List<Animals> animals= new List<Animals>();
        public List<Animals> Animals { get { return animals; } set { animals = value;} }

        public Zoo(string zooName)
        {
            this.ZooName = zooName;

        }

        public void TransferAnimal(Zoo destination, Animals animals)
        {
            destination.Animals.Add(animals);
            this.Animals.Remove(animals);
            Console.WriteLine($"The {animals.Name} has been transferred to {destination.ZooName}");
        }

        public void BornAnimal(Animals animals)
        {
            this.Animals.Add(animals);
            Console.WriteLine($"The {animals.Name} was borned at zoo {this.ZooName}");
        }

        public void Info()
        {
            Console.WriteLine($"Zoo {this.ZooName} has {this.Animals.Count} animals as showed below:");

            foreach (Animals animals in this.Animals)
            {
                Console.WriteLine(animals.Info());
            }

        }

    }
}





