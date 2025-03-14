using Subscriptions;

namespace Factories
{
    public class WebSite : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
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
