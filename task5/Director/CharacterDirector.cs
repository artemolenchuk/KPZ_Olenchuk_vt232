namespace Director
{
    using Builders;
    using Characters;

    public class CharacterDirector
    {
        public Character BuildHero(ICharacterBuilder builder)
        {
            return builder
                .SetName("Скiф")
                .SetHeight(1.85)
                .SetBodyType("Сильний")
                .SetHairColor("Чорний")
                .SetEyeColor("Зеленi")
                .SetClothing("Костюм сталкера")
                .AddToInventory("Viper 'Монолiт'")
                .AddToInventory("Пiстолет скiфа")
                .Build();
        }

        public Character BuildEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetName("Полковник Коршунов")
                .SetHeight(1.90)
                .SetBodyType("Мускулистий")
                .SetHairColor("Лисий")
                .SetEyeColor("Коричневi")
                .SetClothing("Екзоскилет 'Алмаз'")
                .AddToInventory("РПM-74 'Звiр'")
                .AddToInventory("Нiж")
                .Build();
        }
    }
}
