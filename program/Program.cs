using System;
using Interfaces;
using Models;
using Services;

class Program
{
    static void Main()
    {
        try
        {
            ZooInventory zoo = new();

            IAnimal lion = new Lion("Leo");
            IAnimal elephant = new Elephant("Dumbo");

            IEmployee zookeeper = new Zookeeper();
            IEmployee vet = new Veterinarian();

            IEnclosure savanna = new Enclosure("Savanna");
            IEnclosure smallCage = new Enclosure("Small Cage");

            IFood meat = new Food("Meat");
            IFood grass = new Food("Grass");

            zoo.AddAnimal(lion);
            zoo.AddAnimal(elephant);

            zoo.AddEmployee(zookeeper);
            zoo.AddEmployee(vet);

            zoo.AddEnclosure(savanna);
            zoo.AddEnclosure(smallCage);

            zoo.AddFood(meat);
            zoo.AddFood(grass);

            savanna.AddAnimal(lion);
            smallCage.AddAnimal(elephant);

            lion.Eat(meat);
            elephant.Eat(grass);

            zookeeper.Work();
            vet.Work();

            zoo.PrintReport();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
