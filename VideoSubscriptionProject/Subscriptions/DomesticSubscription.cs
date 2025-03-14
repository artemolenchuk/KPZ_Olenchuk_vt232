namespace Subscriptions
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
            : base("Domestic", 10.99m, 6, new List<string> { "News", "Entertainment" }, new List<string> { "HD Streaming" }) { }
    }
}
