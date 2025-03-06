using Interfaces;

namespace Services
{
    public class ZooInventory
    {
        private readonly List<IAnimal> animals = new();
        private readonly List<IEmployee> employees = new();
        private readonly List<IEnclosure> enclosures = new();
        private readonly List<IFood> foodItems = new();

        public void AddAnimal(IAnimal animal)
        {
            if (animal == null)
            {
                throw new ArgumentNullException(nameof(animal), "Animal cannot be null");
            }
            animals.Add(animal);
        }

        public void AddEmployee(IEmployee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Employee cannot be null");
            }
            employees.Add(employee);
        }

        public void AddEnclosure(IEnclosure enclosure)
        {
            if (enclosure == null)
            {
                throw new ArgumentNullException(nameof(enclosure), "Enclosure cannot be null");
            }
            enclosures.Add(enclosure);
        }

        public void AddFood(IFood food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(food), "Food cannot be null");
            }
            foodItems.Add(food);
        }

        public void PrintReport()
        {
            Console.WriteLine($"Animals: {animals.Count}, Employees: {employees.Count}, Enclosures: {enclosures.Count}, Food items: {foodItems.Count}");
        }
    }
}

