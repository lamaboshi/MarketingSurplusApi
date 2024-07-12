namespace MarketingSurplus.Models
{
    public class CompanyProduct
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int CompanyId { get; set; }
        public bool Favor { get; set; }
        public Company? Company { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
        public ICollection<ProductDonation>? ProductDonations { get; set; }
        
    }
}
