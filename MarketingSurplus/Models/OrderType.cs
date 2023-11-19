namespace MarketingSurplus.Models
{
    public class OrderType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Donation> Donations { get; set; }
    }
}
