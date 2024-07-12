namespace MarketingSurplus.Models
{
    public class ProductDonation
    {
        public int Id { get; set; }
        public int CompanyProductId { get; set; }
        public CompanyProduct? CompanyProduct { get; set; }
        public int DonationId { get; set; }
        public Donation? Donation { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
    }
}
