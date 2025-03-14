namespace Subscriptions
{
    public abstract class Subscription
    {
        public string Name { get; }
        public decimal MonthlyFee { get; }
        public int MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> Features { get; }

        protected Subscription(string name, decimal monthlyFee, int minimumPeriod, List<string> channels, List<string> features)
        {
            Name = name;
            MonthlyFee = monthlyFee;
            MinimumPeriod = minimumPeriod;
            Channels = channels;
            Features = features;
        }

        public override string ToString()
        {
            return $"{Name} Subscription: ${MonthlyFee}/month, Min Period: {MinimumPeriod} months, Channels: {string.Join(", ", Channels)}, Features: {string.Join(", ", Features)}";
        }
    }
}
