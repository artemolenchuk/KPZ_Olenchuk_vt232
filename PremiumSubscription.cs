namespace Subscriptions
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
            : base("Premium", 19.99m, 12, new List<string> { "All Channels" }, new List<string> { "4K Streaming", "No Ads", "Offline Viewing" }) { }
    }
}
