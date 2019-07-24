using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Food food = new Food(animaltype.elephant);
            Actions first = new Actions("Iasi");
            Actions second = new Actions("Bucharest");

            Animals firstAnimal = new Animals(animaltype.horse);
            Animals secondAnimal = new Animals(animaltype.giraffe);

            

            first.TransferAnimal(first, secondAnimal);




        }
    }
}
