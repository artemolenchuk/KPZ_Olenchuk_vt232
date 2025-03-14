namespace Builders
{
    using Characters;

    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBodyType(string bodyType);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddToInventory(string item);
        Character Build();
    }
}
