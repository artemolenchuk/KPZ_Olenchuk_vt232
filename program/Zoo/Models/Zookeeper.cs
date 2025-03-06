using Interfaces;
using System;

namespace Models
{
    public class Zookeeper : Employee
    {
        public Zookeeper() : base("Zookeeper") { }

        public override void Work()
        {
            Console.WriteLine("Zookeeper is feeding and taking care of the animals.");
        }
    }
}
