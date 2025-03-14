namespace Subscriptions
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
            : base("Educational", 7.99m, 3, new List<string> { "Documentaries", "Science" }, new List<string> { "No Ads" }) { }
    }
}
