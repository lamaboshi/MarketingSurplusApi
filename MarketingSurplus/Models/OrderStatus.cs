namespace MarketingSurplus.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public int status { get; set; }
        public DateTime DateTime { get; set; }
        public string? Note { get; set; }
        public ICollection<Bill>? Bills { get; set; }
    }
}
