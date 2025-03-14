namespace Prototype
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string type, int age, double weight)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Type, Age, Weight);
            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }
            return clone;
        }

        public void Display(int level = 0)
        {
            Console.WriteLine(new string('-', level * 2) + $"> {Name} ({Type}, Age: {Age}, Weight: {Weight})");
            foreach (var child in Children)
            {
                child.Display(level + 1);
            }
        }
    }
}
