namespace MarketingSurplus.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int OrderProductId { get; set; }
        public OrderProduct? OrderProduct  { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public string? Note { get; set; }
    }
}
