namespace MarketingSurplus.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int CharityId { get; set; }
        public Charity? Charity { get; set; }
        public int OrderTypeId { get; set; }
        public OrderType? OrderType { get; set; }

        public float PricePay { get; set; }
        public ICollection<ProductDonation>? ProductDonations { get; set; }
    }
}
