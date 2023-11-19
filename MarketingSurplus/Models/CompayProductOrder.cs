namespace MarketingSurplus.Models
{
    public class CompayProductOrder
    {
        public int Id { get; set; }
        public int CompanyProductId { get; set; }
        public CompanyProduct CompanyProduct { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<CompayProductOrderOffer> CompayProductOrderOffers { get; set; }
    }
}
