using Subscriptions;

namespace Factories
{
    public class MobileApp : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("Applying mobile discount...");
            return type switch
            {
                "Domestic" => new DomesticSubscription(),
                "Educational" => new EducationalSubscription(),
                "Premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Invalid subscription type")
            };
        }
    }
}
