using Subscriptions;

namespace VideoProvider.Factories
{
    public class ManagerCall : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("Providing personalized service...");
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
