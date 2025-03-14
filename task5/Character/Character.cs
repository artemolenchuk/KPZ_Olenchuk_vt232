namespace Characters
{
    using System;
    using System.Collections.Generic;

    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Deeds { get; set; } = new List<string>();

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothing: {Clothing}");
            Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
            Console.WriteLine($"Deeds: {string.Join(", ", Deeds)}");
            Console.WriteLine();
        }
    }
}
