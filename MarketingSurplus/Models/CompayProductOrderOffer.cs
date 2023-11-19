namespace MarketingSurplus.Models
{
    public class CompayProductOrderOffer
    {
        public int Id { get; set; }
        public int CompayProductOrderId { get; set; }
        public CompayProductOrder CompayProductOrder { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public string Note { get; set; }
    }
}
