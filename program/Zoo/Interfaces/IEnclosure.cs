namespace Interfaces
{
    public interface IEnclosure
    {
        string Type { get; }
        void AddAnimal(IAnimal animal);
    }
}