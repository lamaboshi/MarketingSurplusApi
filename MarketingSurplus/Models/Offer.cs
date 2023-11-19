namespace MarketingSurplus.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public ICollection<CompayProductOrderOffer> CompayProductOrderOffers { get; set; }
    }
}