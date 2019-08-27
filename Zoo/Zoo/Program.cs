using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Zoo zooOne = new Zoo("Iasi");
            Zoo zooTwo = new Zoo("Bucharest");

            Lion firstLion = new Lion("First Lion", Food.Meat);
            Elephant firstElephant = new Elephant("First Elephant",Food.Grass);
            Girrafe firstGirrafe = new Girrafe("First Giraffe", Food.Leaves);
            Horse firstHorse = new Horse("First Horse",Food.Carrots);
            Horse secondHorse = new Horse("Second Horse", Food.Apples);
            Bear firstBear = new Bear("First Bear", Food.Fish);

            zooOne.BornAnimal(firstLion);
            zooOne.BornAnimal(firstHorse);
            zooOne.BornAnimal(firstBear);

            zooTwo.BornAnimal(firstElephant);
            zooTwo.BornAnimal(firstGirrafe);
            zooTwo.BornAnimal(secondHorse);


            zooOne.Info();

            zooTwo.Info();

            zooOne.TransferAnimal(zooTwo, firstLion);

            zooOne.Info();
            zooTwo.Info();

            firstHorse.Eat();
            secondHorse.Eat();






        }
    }
}
