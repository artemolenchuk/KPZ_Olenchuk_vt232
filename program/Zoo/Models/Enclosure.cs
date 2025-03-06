using Interfaces;
using System;
using System.Collections.Generic;

namespace Models
{
    public class Enclosure : IEnclosure
    {
        public string Type { get; }
        private readonly List<IAnimal> animals = new();
        private const int MaxAnimals = 10;

        public Enclosure(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Type cannot be empty", nameof(type));
            }
            Type = type;
        }

        public void AddAnimal(IAnimal animal)
        {
            if (animal == null)
            {
                throw new ArgumentNullException(nameof(animal), "Animal cannot be null");
            }

            if (animals.Count >= MaxAnimals)
            {
                throw new InvalidOperationException("No more animals can be added to this enclosure.");
            }

            animals.Add(animal);
            Console.WriteLine($"Added {animal.Name} the {animal.Species} to {Type} enclosure.");
        }
    }
}


