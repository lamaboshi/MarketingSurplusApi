namespace MarketingSurplus.Models
{
    public class CompanyProduct
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<CompayProductOrder> CompayProductOrders { get; set; }
        public ICollection<Donation> Donations { get; set; }
        
    }
}
