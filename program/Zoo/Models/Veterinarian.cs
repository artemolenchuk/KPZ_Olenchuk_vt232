using Interfaces;
using System;

namespace Models
{
    public class Veterinarian : Employee
    {
        public Veterinarian() : base("Veterinarian") { }

        public override void Work()
        {
            Console.WriteLine("Veterinarian is treating sick animals.");
        }
    }
}
