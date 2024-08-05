namespace MarketingSurplus.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int OrderProductId { get; set; }
        public OrderProduct? OrderProduct{get; set; }
        public string? Message { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Type { get; set; }
        public bool IsRead { get; set; }
    }
}
