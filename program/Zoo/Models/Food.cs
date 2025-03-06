using Interfaces;

namespace Models
{
    public class Food : IFood
    {
        public string FoodType { get; }

        public Food(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Food type cannot be empty", nameof(type));
            }

            FoodType = type;
        }
    }
}

