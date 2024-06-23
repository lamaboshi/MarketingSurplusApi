namespace MarketingSurplus.Models
{
    public class Evalution
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public Subscription? Subscription { get; set; }
        public int RateId { get; set; }
        public Rate? Rate { get; set; }
    }
}
