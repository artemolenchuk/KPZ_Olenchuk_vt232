using Interfaces;

namespace Models
{
    using Interfaces;

    public class Employee : IEmployee
    {
        public string Role { get; }

        public Employee(string role)
        {
            Role = role;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Role} is working.");
        }
    }
}
