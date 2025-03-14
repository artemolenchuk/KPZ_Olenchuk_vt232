using Builders;
using Characters;
using Director;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            CharacterDirector director = new CharacterDirector();

            ICharacterBuilder heroBuilder = new HeroBuilder();
            ICharacterBuilder enemyBuilder = new EnemyBuilder();

            Character hero = director.BuildHero(heroBuilder);
            Character enemy = director.BuildEnemy(enemyBuilder);

            Console.WriteLine("Hero:");
            hero.Display();

            Console.WriteLine("Enemy:");
            enemy.Display();
        }
    }
}
