using Interfaces;
using System;

namespace Models
{
    public class Animal : IAnimal
    {
        public string Name { get; }
        public string Species { get; }

        public Animal(string name, string species)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(species))
            {
                throw new ArgumentException("Species cannot be empty", nameof(species));
            }

            Name = name;
            Species = species;
        }

        public virtual void Eat(IFood food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(food), "Food cannot be null");
            }
            Console.WriteLine($"{Name} the {Species} is eating {food.FoodType}.");
        }
    }
}


