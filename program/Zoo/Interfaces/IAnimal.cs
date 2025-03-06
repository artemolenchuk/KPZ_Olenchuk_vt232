namespace Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        void Eat(IFood food);
    }
}