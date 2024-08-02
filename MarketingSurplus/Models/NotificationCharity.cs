namespace MarketingSurplus.Models
{
    public class NotificationCharity
    {
        public int Id { get; set; }
        public int CharityId { get; set; }
        public Charity? Charity { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
        public bool IsRead { get; set; }
    }
}
