using Subscriptions;

namespace Factories
{
    public interface ISubscriptionCreator
    {
        Subscription CreateSubscription(string type);
    }
}
