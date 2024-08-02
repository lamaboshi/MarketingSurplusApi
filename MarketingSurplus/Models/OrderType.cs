namespace MarketingSurplus.Models
{
    public class OrderType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Percentage { get; set; }
        public bool isAccept { get; set; }
        public ICollection<Donation>? Donations { get; set; }
    }
}
