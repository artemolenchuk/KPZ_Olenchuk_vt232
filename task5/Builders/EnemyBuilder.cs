﻿namespace Builders
{
    using Characters;

    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public EnemyBuilder()
        {
            _character.Deeds = new List<string> { "використання сталкерiв для своєї вигоди та експлуатацiя зони." };
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
