using Prototype;

namespace PrototypePattern
{
    class Program
    {
        static void Main()
        {
            Virus parent = new Virus("Alpha", "RNA", 5, 1.2);
            Virus child1 = new Virus("Beta", "RNA", 2, 0.8);
            Virus child2 = new Virus("Gamma", "RNA", 1, 0.6);
            Virus grandchild = new Virus("Delta", "RNA", 0, 0.3);

            child1.AddChild(grandchild);
            parent.AddChild(child1);
            parent.AddChild(child2);

            Console.WriteLine("Original Virus Family:");
            parent.Display();

            Virus clonedParent = (Virus)parent.Clone();
            Console.WriteLine("\nCloned Virus Family:");
            clonedParent.Display();
        }
    }
}
